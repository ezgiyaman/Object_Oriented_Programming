using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_2
{
   public class Dessert
    {
        public string CookingPlace { get; set; }
        public string Ingredient { get; set; }
        public string CookingTime { get; set; }
        public string Chef { get; set; }

        public string SunumSekli()
        {
            return ($"Kahve ile sunum yapılsın");

        }
    }
}
