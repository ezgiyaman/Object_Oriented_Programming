using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Book book = new Book(); //İNSTANCE ALMAK
            book.BookName = txtBookName.Text;
            book.WriterName = txtWriterName.Text;
            book.PageNumber = txtPageNumber.Text;

            MessageBox.Show($"Book Name: {book.BookName}\nFull Name: {book.WriterName}\nPageNumber : {book.PageNumber}");
        }
    }
}
