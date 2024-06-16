using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Zala
{
    public abstract class DVD : IPrint
    {
        private string name;
        private string genre;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                name = value;
            }
        }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("value");
                }
                genre = value;
            }
        }

        public DVD(string name, string genre)
        {
            this.Name = name;
            this.Genre = genre;
        }

        //метод с параметри, list data - списък от обекти от тип data
        public abstract void CalculateAverage(List<Data> list);

        public abstract void Print();
    }
}
