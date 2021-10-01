using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction.Entities.Abstraction
{
   public abstract class Vehicle
    {
        private DateTime _TicketDate = DateTime.Now;
        public DateTime TicketDate { get => _TicketDate; set => _TicketDate = value; }
        public int TotalySeat { get; set;}
        public abstract string Transport();
        public abstract string Driver();
        public virtual string Defect()
        {
            return "Arıza çözüldü";
        }
    }
}
