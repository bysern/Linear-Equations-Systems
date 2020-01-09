using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompProject02
{
    class EquationActions
    {
        public List<Equation> equations = new List<Equation>();



        public void AddEquation(Equation eq)
        {
            equations.Add(eq);
        }

        public void PrintEquation()
        {
            foreach (Equation item in equations)
            {
                Console.WriteLine(item.EquationForm);
            }
        }




    }
}
