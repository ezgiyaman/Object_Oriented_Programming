using Bank_InterestRate_StaticMethod.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_InterestRate_StaticMethod
{
   public class Static_Method
    {
        public const double AkbankInterestRate = 0.18;
        public const double FinansbankInterestRate = 0.15;
        public const double IsbankInterestRate = 0.12;

        public static double AkbankInterestMoney(Akbank akbank) => akbank.Money * AkbankInterestRate;
        public static double IsbankInterestMoney(Isbank ısbank) => ısbank.Money * IsbankInterestRate;
        public static double FinansbankInterestMoney(Finansbank finansbank) => finansbank.Money * FinansbankInterestRate;
    }
}
