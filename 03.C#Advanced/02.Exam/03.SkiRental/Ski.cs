using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        string manufacturer;

        string model;

        int year;

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                this.year = value;
            }
        }

        public Ski()
        {

        }
        public Ski(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}";
        }


    }
}
