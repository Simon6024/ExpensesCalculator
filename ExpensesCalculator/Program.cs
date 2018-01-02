using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesCalculator.Control;

namespace ExpensesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            new FileContentImporter().Import();
        }
    }
}
