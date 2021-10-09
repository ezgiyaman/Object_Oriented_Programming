using Book_Genres_Repository.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Genres_Repository.Entities.Concrete
{
  public class Book : BaseEntity
    {   
        public string Title{ get; set; }
        public string Concent { get; set; }
        public string Writer { get; set; }
    }
}
