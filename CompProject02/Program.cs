using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompProject02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type linear equations in augmented matrix notation: a1 a2 ... aN d, " +
                                "where a1..N are coefficients and d is constant. Separated by space.");
            Console.WriteLine("Type END to finish entering equations");

            EquationActions equationActions = new EquationActions();
            int EquationNumber = 1;

            while (true)
            {
                Console.Write($"Eq #{EquationNumber}: ");
                string inputUser = Console.ReadLine();
                if(inputUser.ToLower() == "end")
                {
                    break;
                }
                equationActions.AddEquation(new Equation(inputUser));
                EquationNumber++;
            }
            equationActions.PrintEquation();
        }
    }
}
