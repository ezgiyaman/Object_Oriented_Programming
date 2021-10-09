using Book_Genres_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository.Repositories.Abstract
{
   public abstract class BaseGenreRepository
    {
        public abstract void CreateGenre(string Name, string Description);
        public abstract List<Genre> GetGenres();
        public abstract void UppdateGenre(int id, string Name, string Description);
        public abstract void DeleteGenres(int id); 
    }
}
