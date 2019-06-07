using System;
using System.Collections.Generic;
using System.Text;

namespace DTS_Project
{
    //XXX The Serializable() attribute is necessary for objects of the class to be serialized
    [Serializable()]  
    class State
    {
        int population;
        string name;
        List<City> cities;
        public State(int population, string name, List<City> cities)
        {
            this.population = population;
            this.name = name;
            this.cities = cities;
        }
        public bool HasName(string s)
        {
            return s == name;
        }
        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append(name + " (" + population + ") : ");
            foreach (City city in cities)
                buffer.Append(city.ToString());
            return buffer.ToString();
        }
    }

    [Serializable()]
    class City
    {
        int population;
        string name;
        public City(int population, string name)
        {
            this.population = population;
            this.name = name;
        }
        public override string ToString()
        {
            return "\t" + name + " [" + population + "]";
        }
    }                                        
}
