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
    public class GenreRepository : BaseGenreRepository
    {
        public override void CreateGenre(string Name, string Description)
        {
            Genre genre = new Genre();
            genre.Name = Name;
            genre.Description = Description;
        }

        public override void DeleteGenres(int id)
        {
            foreach( Genre genre in FakeData.genres)
            {
                if(genre.Id == id)
                {
                    FakeData.genres.Remove(genre);
                }
                else
                {
                    MessageBox.Show("Silinmek istenilen tür bulunmadı..");
                }
            }
        }

        public override List<Genre> GetGenres()
        {
            return FakeData.genres.ToList();
        }

        public override void UppdateGenre(int id, string Name, string Description)
        {
            foreach(Genre genre in FakeData.genres)
            {
                if(genre.Id == id)
                {
                    Genre genres = new Genre();
                    genres.Id = id;
                    genres.Name = Name;
                    genres.Description = Description;

                }
            }
                
            
  
        }
    }
}
