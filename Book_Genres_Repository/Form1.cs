using Book_Genres_Repository.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Genres_Repository
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        BookRepository bookRepository = new BookRepository();
        GenreRepository genreRepository = new GenreRepository();

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            bookRepository.CreateBook(txtTitel.Text, txtConcent.Text, txtWriter.Text);
            dataGridView1.DataSource = bookRepository.GetBooks();
        }

        private void btnCreatGenre_Click(object sender, EventArgs e)
        {
            genreRepository.CreateGenre(txtName.Text, txtDescription.Text);
            dataGridView2.DataSource = genreRepository.GetGenres();
        }
    }



    
    }

