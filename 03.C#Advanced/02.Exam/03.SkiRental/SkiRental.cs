using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        string name;
        int capacity;

        List<Ski> data = new List<Ski>();

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }

       
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public void Add(Ski ski)
        {
            if (Capacity > 0)
            {
                data.Add(ski);
                this.Capacity--;
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool isRemoved = false;

            //Ski ski = new Ski();
            Ski ski = data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
            
            if (ski != null)
            {
                data.Remove(ski);
                isRemoved = true;
                this.Capacity++;
            }
            else
            {
                isRemoved = false;
            }
            //foreach (Ski currSki in data)
            //{
            //    if (currSki.Manufacturer == manufacturer && currSki.Model == model)
            //    {
            //        data.Remove(ski);
            //        isRemoved = true;
            //    }
            //    else
            //    {
            //        isRemoved = false;
            //    }
            //}

            return isRemoved;
        }

        public Ski GetNewestSki()
        {
            if (data.Count == 0)
            {
                return null;
            }
            else
            {
                var result = data.Max(a => a.Year);
                var res = data.Where(d => d.Year == result).FirstOrDefault();
                return res;
            }
        }

        public Ski GetSki(string manufacturer, string model)
        {
            var res = data.Where(m => m.Manufacturer == manufacturer && m.Model == model).FirstOrDefault();

            return res;
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }


        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var ski in data)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString();
        }
    }
}
