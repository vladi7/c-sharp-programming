using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistrationCore
{
    [Serializable()]
    class Dealer
    {
        public List<Vehicle> CurrentlyOwns = new List<Vehicle>();
        public string DIN { get; private set; }
        public string Name { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public Dealer(string DIN, string name, string state, string city)
        {
            this.DIN = DIN;
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public void AddToCurrentlyOwns(Vehicle vehicle)
        {
            CurrentlyOwns.Add(vehicle);
        }

        public void RemoveFromCurrenlyOwns(Vehicle vehicle)
        {
            CurrentlyOwns.Remove(vehicle);
        }

        public string[] ListCurrentVehicles()
        {
            List<string> currentVehicles = new List<string>();
            foreach (Vehicle v in CurrentlyOwns)
            {
                currentVehicles.Add("                  " + v.ToString());
            }
            return currentVehicles.ToArray();
        }

        public override string ToString()
        {
            return "Dealer: " + DIN  + ", " + Name + ", " + State + ", " + City;
        }
    }
}
