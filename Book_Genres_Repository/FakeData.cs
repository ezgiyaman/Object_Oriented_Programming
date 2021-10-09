using Book_Genres_Repository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository
{
    public class FakeData
    {
        public static List<Book> books = new List<Book>()
        {
            new Book {Id=1,Concent= ".....",Title="Harry Poter ve Felsefe Taşı" ,Writer = "J. K. Rowling "},
            new Book {Id=2,Concent = "......",Title="Şeker Portakalı",Writer ="José Mauro de Vasconcelos"},
            new Book {Id=3,Concent= ".....", Title="Kelebekler Vadisi",Writer = "Sarah Jio"},
        };

        public static List<Genre> genres = new List<Genre>()
        {
            new Genre{Id=1,Name="Fantactic", Description = "Best Book"},
            new Genre{Id=2,Name="Drama", Description = "Best Book"},
            new Genre {Id=3,Name="Comedy", Description = "Best Book" },
        };
    }
}
