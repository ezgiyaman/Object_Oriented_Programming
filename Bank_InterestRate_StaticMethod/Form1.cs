using Bank_InterestRate_StaticMethod.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_InterestRate_StaticMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAkbank_Click(object sender, EventArgs e)
        {
            Akbank akbank = new Akbank();
            akbank.Money = 50000;

            MessageBox.Show(Static_Method.AkbankInterestMoney(akbank).ToString());
        }

        private void btnIsbank_Click(object sender, EventArgs e)
        {
            Isbank ısbank = new Isbank();
            ısbank.Money = 50000;

            MessageBox.Show(Static_Method.IsbankInterestMoney(ısbank).ToString());
        }

        private void btnFinansbank_Click(object sender, EventArgs e)
        {
            Finansbank finansbank = new Finansbank();
            finansbank.Money = 50000;

            MessageBox.Show(Static_Method.FinansbankInterestMoney(finansbank).ToString());
        }
    }

   
    }

