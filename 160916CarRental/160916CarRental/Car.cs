using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160916CarRental
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public bool Rented { get; set; }

        public string MakeAndModel
        {
            get
            {
                return string.Format("{0} {1}", Make, Model);
            }

        }
    }
}
