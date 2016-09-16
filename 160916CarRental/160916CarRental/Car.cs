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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", Make, Model, Colour);
        }
    }
}
