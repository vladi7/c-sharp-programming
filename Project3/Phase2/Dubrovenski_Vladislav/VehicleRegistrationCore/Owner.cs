using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRegistrationCore
{
    [Serializable()]
    class Owner
    {
        private List<Vehicle> CurrentlyOwns = new List<Vehicle>();
        public string SSN { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string BirthDate { get; private set; }
        public string Address { get; private set; }

        public Owner(string SSN,string firstName, string lastName,string address,string birthDate)
        {
            this.SSN = SSN;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.BirthDate = birthDate;
        }
        
        public void AddToCurrentlyOwns(Vehicle vehicle)
        {
            if (!CurrentlyOwns.Contains(vehicle)) CurrentlyOwns.Add(vehicle);
            else MessageBox.Show("The owner already owns this vehicle");
        }
        
        public void RemoveFromCurrentlyOwns(Vehicle vehicle)
        {
            if (CurrentlyOwns.Contains(vehicle)) CurrentlyOwns.Remove(vehicle);
            else MessageBox.Show("The owner does not own this vehicle");
        }

        public string[] ListCurrentlyOwnedVehicles()
        {
            List<string> CurrentlyOwnedVehicles = new List<string>();
            CurrentlyOwnedVehicles.Add(this.ToString());
            if (CurrentlyOwns.Count > 0)
            {
                CurrentlyOwnedVehicles.Add("Currently Owns: ");
            }
            foreach (Vehicle v in CurrentlyOwns)
            {
                CurrentlyOwnedVehicles.Add("               "+ v.ToString() +", Since: "+ v.getTheLastSale().DateOfPurchase +
                        ", License Number: " + v.getTheLastSale().LicenseNumber + ", Price: $" + v.getTheLastSale().Price);
            }
            return CurrentlyOwnedVehicles.ToArray();
        }
    
        public override string ToString()
        {
            return "SSN: " + SSN + ", Name: " + FirstName + " " + LastName + ", Address: " + Address + ", BirthDate: " + BirthDate;
        }
    }
}
