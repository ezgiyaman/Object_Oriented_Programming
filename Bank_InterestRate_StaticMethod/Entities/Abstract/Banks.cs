using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_InterestRate_StaticMethod.Entities.NewFolder1
{
    public abstract class Banks<T>
    {
        public abstract T Id { get; set; }
        public string BankName { get; set; }
        public double Money { get; set; }
        private DateTime _DepositeTime { get; set; }
        public DateTime DepositeDate { get; set; }
    }
}
