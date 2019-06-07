using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using VehicleRegistrationCore;

namespace VehicleRegistration
{
    public partial class VehicleRegistrationSystem : Form
    {
        DataOperations DataOperations;

        public VehicleRegistrationSystem()
        {
            InitializeComponent();
        }

        private void VehicleRegistrationSystem_Load(object sender, EventArgs e)
        {
            // This method is for initialization 
            this.DataOperations = new DataOperations();
        }
    
        private void bnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnRegDealer_Click(object sender, EventArgs e)
        {
            DealerRegistrationDialogbox drd = new DealerRegistrationDialogbox();
            if (drd.ShowDialog() != DialogResult.OK) return;
            this.DataOperations.RegisterDealer(drd.DealerID, drd.DealerName, drd.DealerState, drd.DealerCity);
        }

        private void bnRegVehicle_Click(object sender, EventArgs e)
        {
            VehicleRegistrationDialogbox vrd = new VehicleRegistrationDialogbox();
            if (vrd.ShowDialog() != DialogResult.OK) return;
            this.DataOperations.RegisterVehicle(vrd.VIN, vrd.Make, vrd.Model, vrd.Year, vrd.Color, vrd.InitialDealerID);
        }

        private void bnRegOwner_Click(object sender, EventArgs e)
        {
            OwnerRegistrationDialogbox ord = new OwnerRegistrationDialogbox();
            if (ord.ShowDialog() != DialogResult.OK) return;
            this.DataOperations.RegisterOwner(ord.SSN,ord.FirstName, ord.LastName, ord.Address, ord.BirthDate);
        }

        private void bnListDealers_Click(object sender, EventArgs e)
        {
            ListDialog ld = new ListDialog();
            ld.AddDisplayItems(DataOperations.ListDealers());
            ld.ShowDialog();
        }

        private void bnListVehicles_Click(object sender, EventArgs e)
        {
            ListDialog ld = new ListDialog();         
            ld.AddDisplayItems(DataOperations.ListVehicles());
            ld.ShowDialog();
        }

        private void bnListOwners_Click(object sender, EventArgs e)
        {
            ListDialog ld = new ListDialog();
            ld.AddDisplayItems(DataOperations.ListOwners());
            ld.ShowDialog();
        }

        private void bnTransfer_Click(object sender, EventArgs e)
        {
            OwnershipTransferDialogbox otd = new OwnershipTransferDialogbox();
            if (otd.ShowDialog() != DialogResult.OK) return;
            if (otd.TransferFromDealer && otd.TransferToDealer) // D2D
            {
                DataOperations.TransferD2D(otd.FromDealerID, otd.ToDealerID, otd.VIN);
            }
            else if (otd.TransferFromDealer && otd.TransferToPrivateOwner) // D2O
            {
                DataOperations.TransferD2O(otd.FromDealerID, otd.ToSSN, otd.VIN, otd.Date, otd.Price, otd.LicenceNumber);
            }
            else if (otd.TransferFromPrivateOwner && otd.TransferToDealer) // O2D
            {
                DataOperations.TransferO2D(otd.FromSSN, otd.ToDealerID, otd.VIN, otd.Date);
            }
            else if (otd.TransferFromPrivateOwner && otd.TransferToPrivateOwner) // O2O
            {
                DataOperations.TransferO2O(otd.FromSSN, otd.ToSSN, otd.VIN, otd.Date, otd.Price, otd.LicenceNumber);
            }
        }

        private void bnListOwnedVehicles_Click(object sender, EventArgs e)
        {
            ListDialog ld = new ListDialog();
            LocateOwnerDialogbox lod = new LocateOwnerDialogbox();
            if (lod.ShowDialog() != DialogResult.OK) return;
            if(DataOperations.ListOwnedVehicles(lod.SSN) != null)
            {
                ld.AddDisplayItems(DataOperations.ListOwnedVehicles(lod.SSN));
                ld.ShowDialog();
            }
            else
            {
                MessageBox.Show("Owner was not found");
            }
        }

        private void ListOwnersHistory_Click(object sender, EventArgs e)
        {
            ListDialog ld = new ListDialog();
            LocateVehicleDialogbox lvd = new LocateVehicleDialogbox();
            if (lvd.ShowDialog() != DialogResult.OK) return;
            if(DataOperations.ListOwnersHistory(lvd.VIN) != null)
            {
               ld.AddDisplayItems(DataOperations.ListOwnersHistory(lvd.VIN));
               ld.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Vehicle was not found");
            }     
        }

        private void bnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VRS Info Files|*.inf";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {          
                    TextReader trs = new StreamReader(openFileDialog.FileName);
                try
                {
                    string s;
                    List<string> words;
                    int stringIndex;
                    while (((s = trs.ReadLine()) != null) && (s != ""))
                    {
                        words = new List<string>();
                        while (true)
                        {
                            if ((stringIndex = s.IndexOf('"')) == -1) break;
                            s = s.Substring(stringIndex + 1);
                            stringIndex = s.IndexOf('"');
                            words.Add(s.Substring(0, stringIndex));
                            s = s.Substring(stringIndex + 1);
                        }
                        OperationPerformer(words);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong" + ex.ToString());
                }
                finally
                {
                    trs.Close();
                }
            }
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "VRS Files|*.vrs";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream f = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    BinaryFormatter fo = new BinaryFormatter();
                    fo.Serialize(f, DataOperations);
                    f.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Something is wrong or unusual");
                }
            }
        }

        private void bnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VRS Files|*.vrs";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream f = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                    BinaryFormatter fo = new BinaryFormatter();
                    this.DataOperations  = (DataOperations)fo.Deserialize(f);
                    f.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong or unusual");
                }
            }
        }

        private void OperationPerformer(List<string> words)
        {
            string currentOperation = "";
            if (words.Count > 0) currentOperation = words[0];
            else return;
            
            ListDialog ld = new ListDialog();
            switch (currentOperation)
            {
                case "RegisterDealer":
                    {
                        DataOperations.RegisterDealer(words[1], words[2], words[3], words[4]);
                        break;
                    }
                case "RegisterVehicle":
                    {
                        DataOperations.RegisterVehicle(words[1], words[2], words[3], words[4], words[5], words[6]);
                        break;
                    }
                case "RegisterOwner":
                    {
                        DataOperations.RegisterOwner(words[1], words[2], words[3], words[4], words[5]);
                        break;
                    }
                case "TransferD2D":
                    {
                        DataOperations.TransferD2D(words[1], words[2], words[3]);
                        break;
                    }
                case "TransferD2O":
                    {
                        DataOperations.TransferD2O(words[1], words[2], words[3], words[4], words[5], words[6]);
                        break;
                    }
                case "TransferO2D":
                    {
                        DataOperations.TransferO2D(words[1], words[2], words[3], words[4]);
                        break;
                    }
                case "TransferO2O":
                    {
                        DataOperations.TransferO2O(words[1], words[2], words[3], words[4], words[5], words[6]);
                        break;
                    }
                case "ListOwnersOfVehicle":
                    {
                        try
                        {
                            ld.AddDisplayItems(DataOperations.ListOwnersHistory(words[1]));
                            ld.ShowDialog();
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("Vehicle was not found");
                        }                                        
                         break;                         
                    }
                case "ListVehiclesOfOwner":
                    {
                        try
                        {
                            ld.AddDisplayItems(DataOperations.ListOwnedVehicles(words[1]));
                            ld.ShowDialog();
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("Owner was not found");
                        }
                        break;
                    }
                case "ListDealers":
                    {
                        ld.AddDisplayItems(DataOperations.ListDealers());
                        ld.ShowDialog();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Operation was not found");
                        break;
                    }
            }
        }
    }
}
