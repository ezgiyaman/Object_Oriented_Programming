using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor
{
  public class Airplane
    {
        public int TotalySeat { get; set; }
        public int Totalyperson { get; set; }
        public string money { get; set; }
        public int BusinessClassPerson { get; set; }

        public Airplane(int TotalySeat, int totalyperson) //Constructor
        {
            this.TotalySeat = TotalySeat;
            this.Totalyperson = totalyperson;

            MessageBox.Show($"Seat:{this.TotalySeat} \nTotalyPerson: {this.Totalyperson}");
        }

        public Airplane() //Constructor
        {
            this.BusinessClassPerson = BusinessClassPerson;
            this.money = money;

            MessageBox.Show($"BusinessClassPerson:{this.BusinessClassPerson}\nmoney: {this.money}");


        }
    }
}

