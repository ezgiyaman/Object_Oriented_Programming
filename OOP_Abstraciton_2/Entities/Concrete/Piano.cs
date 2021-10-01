using OOP_Abstraciton_2.Entities.Abstraciton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraciton_2.Entities.Concrete
{
    public class Piano : Instrument
    {
        public override CalmaTuru CalmaTuru { get => CalmaTuru.TusluCalma; set => throw new NotImplementedException(); }

        public override string Cal()
        {
            return "Piyano Çalıyor.";
        }
    }
}
