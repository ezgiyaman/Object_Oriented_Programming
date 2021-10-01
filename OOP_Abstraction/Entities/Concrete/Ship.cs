using OOP_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction.Entities.Concrete
{
    public class Ship : Vehicle
    {
        public override string Driver()
        {
            return "KAPTAN";
        }

        public override string Transport()
        {
            return "SU YOLU ";
        }
    }
}
