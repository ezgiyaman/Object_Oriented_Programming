using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class
{ //Oluşturmuş olduğum student class'ına ram üzerinden bir sınıf oluşturulduğunda içine atamış olduğum değişkenlere ulaşılmamaktadır.Çünkü erişim yapısı private gelmektedir.Bizim bunu public olarak değiştirmemiz gerekir ki projeye her yerden ulaşabilmek için.
   public class Book
    {
        public string BookName;
        public string WriterName;
        public string PageNumber;
    }
}
