using OOP_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction.Entities.Concrete
{
    public class Car : Vehicle
    {
        public override string Driver()
        {
            return "ŞOFÖR";
        }
        public override string Transport()
        {
            return "KARA YOLU";
        }
    }
}
