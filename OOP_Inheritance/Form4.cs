using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Inheritance
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                Student student = new Student();
                HumanAdd(student);
                Teacher teacher = new Teacher();
                HumanAdd(teacher);

            }
            void HumanAdd(Human human)
            {

            }
        }
    }
}
