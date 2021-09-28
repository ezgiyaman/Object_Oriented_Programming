using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Encapsulation
{// Davranış ve özellikler sınıfta soyutlanır ve saklanır. Kapsülleme ile hangi özellik ve davranışın dışarıdan kullanılacağını belirleyebiliriz. 
    public  class Home
    {
        private int _DoorNumber;
        public int DoorNumber
        {
            get => _DoorNumber;
            set
            {
                if (value > 0)
                    _DoorNumber = value;
                else
                    MessageBox.Show($"Kapı numarası sıfırdan küçük olamaz!");
            }
        }
        private int _Floor;
        public int Floor
        {
            get => _Floor;
            set
            {
                if (value > 0)
                    _Floor = value;
                else
                    MessageBox.Show($"Sıfırıncı kattan daha altta kat yoktur.");
            }

        }
        public string Street { get; set; }
        public string AreaName { get; set; }
    }
}

