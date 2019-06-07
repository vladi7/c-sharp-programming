using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationCore
{
    [Serializable()]
    class Sale
    {
        public Owner PastOwner { get; private set; }
        public string DateOfPurchase { get; private set; }
        public string DateOfSale { get; private set; }
        public string Price { get; private set; }
        public string LicenseNumber { get; private set; }

        public Sale(string dateOfPurchase, string price)
        {
            this.DateOfPurchase = dateOfPurchase;
            this.Price = price;
        }

        public void AddDateOfSale(string dateOfSale)
        {
            this.DateOfSale = dateOfSale;
        }

        public void AddLicenseNumber(string licenseNumber)
        {
            this.LicenseNumber = licenseNumber;
        }

        public override string ToString()
        {       
            return PastOwner.ToString() + " From: " + DateOfPurchase + " To: " +  DateOfSale + " " + "Price: $" + Price;
        }

        public void UpdatePastOwner(Owner owner)
        {
            this.PastOwner = owner;
        }
    }
}
