using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    class NationalSavings : ISavings
    {
        public NationalSavings()
        {
            Console.WriteLine("National Savings Account.");
        }
    }
}
