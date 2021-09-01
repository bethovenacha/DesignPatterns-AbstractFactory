using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoan CreateLoan()
        {
            NationalLoan obj = new NationalLoan();
            return obj;
        }

        public override ISavings CreateSavings()
        {
            NationalSavings obj = new NationalSavings();
            return obj;
        }
    }
}
