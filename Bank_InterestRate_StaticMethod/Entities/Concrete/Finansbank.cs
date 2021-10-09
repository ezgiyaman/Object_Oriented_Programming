using Bank_InterestRate_StaticMethod.Entities.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_InterestRate_StaticMethod.Entities.Concrete
{
    public class Finansbank : Banks<string>
    {
        public override string Id { get ; set; }
    }
}
