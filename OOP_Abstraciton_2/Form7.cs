using OOP_Abstraciton_2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Abstraciton_2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnDrum_Click(object sender, EventArgs e)
        {
            Drum drum = new Drum();
            MessageBox.Show(drum.Cal());
        }
        private void btnPiano_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano();
            MessageBox.Show(piano.Cal());
        }
        private void btnFlute_Click(object sender, EventArgs e)
        {
            Flute flute = new Flute();
            MessageBox.Show(flute.Cal());
        }
    }
}
