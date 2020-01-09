using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompProject02
{
    class Equation
    {
        public string EquationForm { get; private set; }

        public Equation(string augmentedEquation)
        {
            this.EquationForm = setEquation(augmentedEquation);
        }

        public static string setEquation(string augmentedEquation) {

            string[] equations = augmentedEquation.Split(null);

            int Index = 1;
            string equation = string.Empty;
            for (int i = 0; i < equations.Length; i++)
            {
                if(i == 0)
                {
                    equation += equations[i] + "*x" + Index;
                    Index++;
                }

                else if(i == equations.Length-1)
                {
                    equation += " = " + equations[i];
                }

                else
                {
                    equation += " + " + equations[i] + "*x" + Index;
                    Index++;
                }
            }
            return equation;
        }

    }
}
