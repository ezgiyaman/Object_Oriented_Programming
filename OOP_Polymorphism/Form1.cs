using OOP_Polymorphism.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatSound_Click(object sender, EventArgs e)
        {

            Cat cat = new Cat()
            {
                Id = 1,
                Name = "Pamuk",
                Genus = "Sibirya Kedisi"

            };
            cat.CatSound();

        }

        private void btnDogSound_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog()
            {
                Id = 1,
                Name = "Karabaş",
                Genus = "Sivas Kangalı",

            };
            dog.DogSound();
        }
    }
}
