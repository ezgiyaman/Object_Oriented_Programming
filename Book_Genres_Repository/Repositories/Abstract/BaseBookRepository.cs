using Book_Genres_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository.Repositories.Abstract
{
  public abstract class BaseBookRepository
    {
        public abstract void CreateBook(string Title, string Content,string Writer);
        public abstract List<Book> GetBooks();
        public abstract void UppdateBook(int id, string Title, string Concent,string Writer);
        public abstract void DeleteBook(int id);

        
    }
}
