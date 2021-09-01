using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.AbstractFactory
{
    public abstract class ICreditUnionFactory
    {
        public abstract ISavings CreateSavings();
        public abstract ILoan CreateLoan();
    }
}
