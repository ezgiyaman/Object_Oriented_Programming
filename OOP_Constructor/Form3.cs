using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane(Convert.ToInt32(txtTotalySeat.Text), Convert.ToInt32(txtTotalyPerson.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Airplane airplane = new Airplane(Convert.ToInt32(txtMoney.Text), Convert.ToInt32(txtBusinessClassPerson.Text));
        }
    }
}
