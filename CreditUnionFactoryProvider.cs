using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
   public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnion(string accountNumber) {
            if (accountNumber.Contains("CITY"))
            {
                return new CityCreditUnionFactory();
            }
            else if (accountNumber.Contains("NATIONAL"))
            {
                return new NationalCreditUnionFactory();
            }
            else {
                return null;
            }
        }
    }
}
