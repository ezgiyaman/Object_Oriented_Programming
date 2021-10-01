using OOP_Abstraciton_2.Entities.Abstraciton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraciton_2.Entities.Concrete
{
    class Flute : Instrument
    {
        public override CalmaTuru CalmaTuru { get => CalmaTuru.UfleyerekCalma; set => throw new NotImplementedException(); }

        public override string Cal()
        {
            return "Flüt Çalıyor.";
        }
    }
}
