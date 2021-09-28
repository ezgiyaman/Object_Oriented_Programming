using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Encapsulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Street = "Flower Street";
            home.AreaName = "Papatya ";
            home.Floor = 3;
            home.DoorNumber = 11;
        }
    }
}
