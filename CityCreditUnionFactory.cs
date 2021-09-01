using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    public class CityCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoan CreateLoan()
        {
            CityLoan obj = new CityLoan();
            return obj;
        }

        public override ISavings CreateSavings()
        {
            CitySavings obj = new CitySavings();
            return obj;
        }
    }
}
