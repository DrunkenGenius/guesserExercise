using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Guess the Thies");
            for (int i=1; i <= MaxTrials; i++)
            {
                if (Console.ReadLine() == "Henning")
                {
                    Console.WriteLine("YouGuessed the thief");
                    break;
                }
                else
                {
                    Console.WriteLine("Du har " + (MaxTrials - i) + " forsøg tilbage");
                        
                    if (i == 2)
                        Console.WriteLine("har 2 n'er");
                    if (i == 4)
                        Console.WriteLine("Starter med et h");
                    if (i == 6)
                        Console.WriteLine("slutter med ing");





                }

                Console.WriteLine("You have " + (MaxTrials - i) + (" tries left."));
            }
            Console.ReadLine();
        }
    }
}
