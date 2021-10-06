using OOP_Polymorphism.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Polymorphism.Entities.Concrete
{
    public class Dog : Animals
    {
        public void DogSound()
        {
            MessageBox.Show("Havlama Sesi");
        }
    }
}
