using Book_Genres_Repository.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository.Entities.Concrete
{
  public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string  Description { get; set; }
    }
}
