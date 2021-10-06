using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism.Entities.Abstract
{
    public abstract class Animals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genus { get; set; }

        private DateTime _VaccinationDate = DateTime.Now;
        public DateTime VaccinationDate { get; set; }
        public void Sound()
        {

        }
    }
}
