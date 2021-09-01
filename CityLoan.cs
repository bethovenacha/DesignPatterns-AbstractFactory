using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    class CityLoan : ILoan
    {
        public CityLoan()
        {
            Console.WriteLine("City Loan Account.");
        }
    }
}
