using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
   public class CitySavings : ISavings
    {
        public CitySavings()
        {
            Console.WriteLine("City Savings Account.");
        }
    }
}
