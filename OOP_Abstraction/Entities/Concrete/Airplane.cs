using OOP_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction.Entities.Concrete
{
    public class Airplane : Vehicle
    {
        public override string Driver()
        {
            return "PİLOT";
        }
        public override string Transport()
        {
            return "HAVA YOLU";
        }
    }
}
