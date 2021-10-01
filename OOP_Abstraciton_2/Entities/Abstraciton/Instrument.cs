using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstraciton_2.Entities.Abstraciton
{ 
    //Müzik enstrümanlarının satış mağazası 
   public abstract class Instrument
    {
        public int Id { get; set;}

        private int _Stock;
        public int Stock 
        { get => _Stock;
          set
            {
                if (value > 0)
                {
                    _Stock = value;
                }
                else
                    MessageBox.Show($"Stok miktarı sıfırdan küçük olmamalıdır.");
            }          
        }
        public abstract string Cal();
        public abstract CalmaTuru CalmaTuru { get; set; }
        
    }
}
