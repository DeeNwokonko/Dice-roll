using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chidinma_Dice_roll_program
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("How many would you like to roll? ");

               
                int number = int.Parse(Console.ReadLine());

                
                Random random = new Random();

                int totalRoll = 0;
                double averageRoll = 0.0;

                
                for (int i = 0; i < number; i++)
                {
                   
                    int currentRoll = random.Next(1, 7);
                
                    totalRoll += currentRoll;
                }

              
                averageRoll = totalRoll / number;

                // print results
                Console.WriteLine("Total roll: " + totalRoll);
                Console.WriteLine("Average roll: " + averageRoll);
                Console.ReadLine();
            }
        }
    }
    }
}
