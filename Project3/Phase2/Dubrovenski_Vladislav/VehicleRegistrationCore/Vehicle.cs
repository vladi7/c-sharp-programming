using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationCore
{
    [Serializable()]
    class Vehicle
    {
        public List<Sale> SalesInformation { get; private set; }
        public Owner CurrentOwner { get; private set; }
        public string DateOfPurchaise { get; private set; }
        public string VIN { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public string Year { get; private set; }
        public string Color { get; private set; }
        public string InitialDealer { get; private set; }


        public Vehicle(string VIN, string make, string model, string year, string color, string initialDealerName)
        {
            this.VIN = VIN;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.InitialDealer = initialDealerName;
            SalesInformation = new List<Sale>();
        }

        public void AddToSalesInformation(string dateOfPurchase, string price,string licenseNumber)
        {
            Sale s = new Sale(dateOfPurchase, price);
            s.AddLicenseNumber(licenseNumber);
            SalesInformation.Add(s);
            DateOfPurchaise = dateOfPurchase;
        }

        public void AddToSalesInfoDate(string dateOfSale, Sale sale)
        {
            if (SalesInformation.Contains(sale))
            {
                int i = SalesInformation.IndexOf(sale);
                SalesInformation[i].AddDateOfSale(dateOfSale);
            }
        }

        public void UpdateCurrentOwner(Owner owner)
        {
            CurrentOwner = owner;
            if(owner != null) this.getTheLastSale().UpdatePastOwner(owner); // trying

        }

        public string[] ListOwnershipInformation()
        {
            List<string> VehicleHistory = new List<string>();
            VehicleHistory.Add( this.ToString());
            if (CurrentOwner != null) VehicleHistory.Add("       Owned By: " + CurrentOwner.ToString() +
                    ", Since: " + this.getTheLastSale().DateOfPurchase+ ", License Number: " + this.getTheLastSale().LicenseNumber+
                    ", Price: $" + this.getTheLastSale().Price);
            if(SalesInformation.Count > 1)  VehicleHistory.Add("   History: "); 
            foreach (Sale s in SalesInformation)
            {
               if(s.DateOfSale != null) VehicleHistory.Add("        " + s.ToString());             
            }
            return VehicleHistory.ToArray();
        }

        public Sale getTheLastSale()
        {
            return this.SalesInformation.Last();
        }

        public override string ToString()
        {
            return "VIN: " + VIN + ", Make: " + Make + ", Model: " +  Model + ", Year: " + Year + ", Color: " + Color;
        }      
    }
}
