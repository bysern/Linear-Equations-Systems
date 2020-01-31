using System;

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

            try
            {
                while (true)
                {
                    Console.Write($"Eq #{EquationNumber}: ");
                    string inputUser = Console.ReadLine();
                    if (inputUser.ToLower() == "end")
                    {
                        break;
                    }
                    equationActions.AddEquation(new Equation(inputUser));
                    EquationNumber++;
                }
                equationActions.PrintEquation();

                Console.WriteLine("And solutions are: ");
                equationActions.PrintSolution();
            }

            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message + " Try again");
            }
        }
    }
}
