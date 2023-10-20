using System;

namespace Selectionstatements
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(0, 1001);
            //int userInput;
            //var counter = 0;


            //do
            //{

            //    Console.WriteLine("pick a number from 1 - 1000");
            //    userInput = int.Parse(Console.ReadLine());

            //    if (userInput < favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too low");
            //    }
            //    else if (userInput > favNumber)
            //    {
            //        Console.WriteLine($"{userInput} is too high");
            //    }
            //    else
            //    {
            //        Console.WriteLine("you got it buck a roo!!");
            //    }

            //    counter++;

            //    Console.WriteLine($"you have guessed {counter} times");

            //} while (userInput != favNumber);


            //switch-Case
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

           
             switch (subject.ToLower())
             {
                    case "math":
                        Console.WriteLine("I love math!");
                        break;
                    case "science:":
                        Console.WriteLine("science is amazing!");
                        break;
                    case "english lit":
                        Console.WriteLine("english lit is boring");
                        break;
                    case "reading":
                        Console.WriteLine("reading is the best");
                        break;
                case "physics":
                    Console.WriteLine("Physics is the bomb");
                        break;
                default:
                        Console.WriteLine("Not really sure about that subject");
                        break;


             }
            
        }   







    }
}


