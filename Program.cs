using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many years experience do you have in professional programming");
                string years = Console.ReadLine();
                int exp_years = int.Parse(years);
                if (exp_years == 0)
                    Console.WriteLine("Need lots of practice");
                else if (exp_years == 1)
                    Console.WriteLine("Looks like you have little experience");
                else if (exp_years == 2)
                    Console.WriteLine("Wow!You've been doing this for a little while");
                else
                    Console.WriteLine("You are an expert");

            }
            catch
            {
                Console.WriteLine("Please enter an integer");
            }
        }    

        }
        }
    

