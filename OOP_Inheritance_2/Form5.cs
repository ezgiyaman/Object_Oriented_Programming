using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Inheritance_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnMilky_Click(object sender, EventArgs e)
        {

            MilkyDessert milkyDessert = new MilkyDessert();
            MessageBox.Show(milkyDessert.SunumSekli());
        }

        private void btnSyrup_Click(object sender, EventArgs e)
        {
            SyrupDessert syrupDessert = new SyrupDessert();
            MessageBox.Show(syrupDessert.SunumSekli());
        }
    }
}
