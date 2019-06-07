using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace VehicleRegistrationCore
{
    [Serializable()]
    public class DataOperations
    {
        private List<Owner> Owners = new List<Owner>();

        private List<Dealer> Dealers = new List<Dealer>();

        private List<Vehicle> Vehicles = new List<Vehicle>();

        public DataOperations() { }

        public void RegisterDealer(string DIN, string name, string state, string city)
        {
            int indexOfDealer = Dealers.FindIndex(d => (d.DIN == DIN));
            if (indexOfDealer != -1)
            {
                MessageBox.Show("Dealer is already registered");
            }
            else Dealers.Add(new Dealer(DIN, name, state, city));
        }

        public void RegisterVehicle(string VIN, string make, string model, string year, string color, string initialDealerID)
        {
            int indexOfDealer = Dealers.FindIndex(d => (d.DIN == initialDealerID));
            int indexOfVehicle = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (indexOfDealer == -1)
            {
                MessageBox.Show("Dealer cannot be found");
            }
            else if (indexOfVehicle != -1)
            {
                MessageBox.Show("Vehicle is already registered");
            }
            else
            {
                Vehicle vehicle = new Vehicle(VIN, make, model, year, color, Dealers[indexOfDealer].Name);
                Vehicles.Add(vehicle);
                Dealers[indexOfDealer].AddToCurrentlyOwns(vehicle);
            }        
        }

        public void RegisterOwner(string SSN, string firstName, string lastName, string address, string birthDate)
        {
            int i = Owners.FindIndex(o => (o.SSN == SSN));
            if (i != -1)
            {
                MessageBox.Show("Owner is already registered");
            }
            else Owners.Add(new Owner(SSN, firstName, lastName, address, birthDate));
        }

        public string[] ListDealers()
        {
            List<string> dealersDisplay = new List<string>();
            foreach (Dealer d in Dealers)
            {
                dealersDisplay.Add(d.ToString());
                if(d.CurrentlyOwns.Count > 0)
                {
                    dealersDisplay.Add("     Vehicles Owned");
                } 
                foreach (string s in d.ListCurrentVehicles())
                {
                    dealersDisplay.Add(s);
                }
            }       
            return dealersDisplay.ToArray();
        }

        public string[] ListVehicles()
        {
            List<string> vehicleDisplay = new List<string>();
            foreach (Vehicle v in Vehicles)
            {               
                vehicleDisplay.Add(v.ToString());
            }
            return vehicleDisplay.ToArray();
        }

        public string[] ListOwners()
        {
            List<string> ownerDisplay = new List<string>();
            foreach (Owner o in Owners)
            {
                ownerDisplay.Add(o.ToString());
            }
            return ownerDisplay.ToArray();
        }

        public string[] ListOwnedVehicles(string SSN)
        {
            int i = Owners.FindIndex(o => (o.SSN == SSN));
            if (i == -1)
            {
                return null;
            }
            else return Owners[i].ListCurrentlyOwnedVehicles();
        }

        public string[] ListOwnersHistory(string VIN)
        {
            int i = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (i == -1)
            {
                return null;
            }
            else return Vehicles[i].ListOwnershipInformation();
        }

        public void TransferD2D(string fromDIN, string toDIN, string VIN)
        {
            Dealer FromDealer = null;
            Dealer ToDealer = null;
            int indexOfDealer1 = Dealers.FindIndex(d => (d.DIN == fromDIN));
            int indexOfDealer2 = Dealers.FindIndex(d => (d.DIN == toDIN));
            int indexOfVehicle = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (indexOfDealer1 == -1 || indexOfDealer2 == -1)
            {
                MessageBox.Show("Dealer is not registered");
                return;
            }
            else if (indexOfVehicle == -1)
            {
                MessageBox.Show("Vehicle is not registered");
                return;
            }
            else
            {
                FromDealer = Dealers[indexOfDealer1];
                ToDealer = Dealers[indexOfDealer2];
            }
            FromDealer.RemoveFromCurrenlyOwns(Vehicles[indexOfVehicle]);
            ToDealer.AddToCurrentlyOwns(Vehicles[indexOfVehicle]);
        }

        public void TransferD2O(string fromDIN, string toSSN, string VIN, string dateOfPurchaise, string price, string licenseNumber)
        {
            Dealer FromDealer = null;
            Owner ToOwner = null;
            int indexOfDealer = Dealers.FindIndex(d => (d.DIN == fromDIN));
            int indexOfOwner = Owners.FindIndex(o => (o.SSN == toSSN));
            int indexOfVehicle = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (indexOfDealer == -1)
            {
                MessageBox.Show("Dealer is not registered");
                return;
            }
            else if (indexOfOwner == -1)
            {
                MessageBox.Show("Owner is not registered");
                return;
            }
            else if (indexOfVehicle == -1)
            {
                MessageBox.Show("Vehicle is not registered");
                return;
            }
            else
            {
                FromDealer = Dealers[indexOfDealer];
                ToOwner = Owners[indexOfOwner];
            }
            FromDealer.RemoveFromCurrenlyOwns(Vehicles[indexOfVehicle]);
            ToOwner.AddToCurrentlyOwns(Vehicles[indexOfVehicle]);
            Vehicles[indexOfVehicle].AddToSalesInformation(dateOfPurchaise, price, licenseNumber);
            Vehicles[indexOfVehicle].UpdateCurrentOwner(ToOwner);
        }

        public void TransferO2D(string fromSSN, string toDIN, string VIN, string dateOfSale)
        {
            Owner FromOwner = null;
            Dealer ToDealer = null;
            int indexOfDealer = Dealers.FindIndex(d => (d.DIN == toDIN));
            int indexOfOwner = Owners.FindIndex(o => (o.SSN == fromSSN));
            int indexOfVehicle = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (indexOfDealer == -1)
            {
                MessageBox.Show("Dealer is not registered");
                return;
            }
            else if (indexOfOwner == -1)
            {
                MessageBox.Show("Owner is not registered");
                return;
            }
            else if (indexOfVehicle == -1)
            {
                MessageBox.Show("Vehicle is not registered");
                return;
            }
            else
            {
                ToDealer = Dealers[indexOfDealer];
                FromOwner = Owners[indexOfOwner];
            }
            FromOwner.RemoveFromCurrentlyOwns(Vehicles[indexOfVehicle]);
            Vehicles[indexOfVehicle].UpdateCurrentOwner(null);
            Vehicles[indexOfVehicle].AddToSalesInfoDate(dateOfSale, Vehicles[indexOfVehicle].getTheLastSale());
            ToDealer.AddToCurrentlyOwns(Vehicles[indexOfVehicle]);
        }

        public void TransferO2O(string fromSSN, string toSSN, string VIN, string dateOfPurchase, string price, string licenseNumber)
        {
            Owner FromOwner = null;
            Owner ToOwner = null;
            int indexOfOwner1 = Owners.FindIndex(o => (o.SSN == fromSSN));
            int indexOfOwner2 = Owners.FindIndex(o => (o.SSN == toSSN));
            int indexOfVehicle = Vehicles.FindIndex(v => (v.VIN == VIN));
            if (indexOfOwner1 == -1)
            {
                MessageBox.Show("Dealer is not registered");
                return;
            }
            else if (indexOfOwner2 == -1)
            {
                MessageBox.Show("Owner is not registered");
                return;
            }
            else if (indexOfVehicle == -1)
            {
                MessageBox.Show("Vehicle is not registered");
                return;
            }
            else
            {                
                FromOwner = Owners[indexOfOwner1];
                ToOwner = Owners[indexOfOwner2];
            }
            FromOwner.RemoveFromCurrentlyOwns(Vehicles[indexOfVehicle]);
            Vehicles[indexOfVehicle].AddToSalesInfoDate(dateOfPurchase, Vehicles[indexOfVehicle].getTheLastSale());
            Vehicles[indexOfVehicle].AddToSalesInformation(dateOfPurchase, price, licenseNumber);
            ToOwner.AddToCurrentlyOwns(Vehicles[indexOfVehicle]);
            Vehicles[indexOfVehicle].UpdateCurrentOwner(ToOwner);
        }
    }
}