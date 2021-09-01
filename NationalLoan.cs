using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    public class NationalLoan : ILoan
    {
        public NationalLoan()
        {
            Console.WriteLine("National Loan Account.");
        }
    }
}
