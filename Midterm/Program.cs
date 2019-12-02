using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
        //1.) Sequence structure executes code in the order that it is written.
        //    Selection statements execute code based on if certain statements remain true or are false (if, if...else, switch)
        //    Repitition statements execute the code repeatedly (while, do..while, for)
       
    {
        static void Main(string[] args)
        {
            // note: I could not figure out how to include all of my code in the same program
            //       after writing the infinite loop.  I put // in front of the loop
            //       code so that the rest of my code would work properly.
            
            //    bool keepLooping;

              //  keepLooping = true;

              //  while (keepLooping == true)
              //  {
                //    Console.WriteLine();
             //   }
            
            int variable = 2;

            while(variable < 136)
            {
                Console.WriteLine();
                Console.WriteLine("[{0}]",variable);
                variable *= 2;
            }
            Console.ReadLine();
            //

            int a;

            for (a = 45; a >= 1; --a)
            {
                if (a == 1)
                {
                    Console.Write("{0}", a);
                   
                }
                else
                {
                    Console.Write("{0},", a);
                   
                }
                
                
            }
            Console.ReadLine();

            //

            int o = 1;
              while (o <= 21)
            {
                {
                    if ((o % 2) == 0)
                      { 
                        Console.Write(" ");
                    }
                    else if ((o % 2) != 0)
                    {
                        Console.Write(o);
                        } 
                         o++; 
                } 
            }
            Console.ReadLine();

            //
            // 7.) This code outputs a "*" in the console.
            //     Written with a while statement, the code does not output the "*".   
            int n = 8;
            int i = 10;

            while (i < n)
            {
                Console.Write("*");
                i++;

                    }
            Console.ReadLine();

            //
            // I use both boolean variables in the if statement by using "&&".

            bool icyRain;
            bool tornadoWarning;

            icyRain = false;
            tornadoWarning = false;

            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }
            Console.ReadLine();
            //




















        }








    }
    }

