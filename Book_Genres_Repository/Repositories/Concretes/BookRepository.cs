using Book_Genres_Repository.Entities.Concrete;
using Book_Genres_Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Genres_Repository.Repositories.Concretes
{
    public class BookRepository : BaseBookRepository
    {
        public override void CreateBook(string Title, string Content, string Writer)
        {
            Book book = new Book();
            book.Title = Title;
            book.Concent = Content;
            book.Writer = Writer;
            FakeData.books.Add(book);
        }

        public override void DeleteBook(int id)
        {
           foreach(Book book in FakeData.books) 
            {
                if(book.Id == id) 
                {
                    
                    FakeData.books.Remove(book); 
                }
                else
                {
                    MessageBox.Show("Silinmek istenilen kitap bulunmadı."); 
                }
            }
        }

        public override List<Book> GetBooks() 
        {
            return FakeData.books.ToList(); 
        }

        public override void UppdateBook(int id, string Title, string Concent, string Writer)
        {
            foreach(Book book in FakeData.books)
            {
                if(book.Id == id)
                {
                    book.Title = Title;
                    book.Concent = Concent;
                    book.Writer = Writer;
                }
                
            }
        }
    }
}
