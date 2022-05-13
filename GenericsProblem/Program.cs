using GenericsProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome to Generic Problem==========");
            Console.WriteLine("\t->Please Select the Option Which can be Executed<-");
            Console.WriteLine("\t1. FindMaxValueOutOfThree \n\t2. Exit");
            Console.Write("\tEnter The Selected Option: ");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int x = 40, y = 30, z = 10;
                    if (Generic.FindMaxValueOutOfThree(x, y, z) != 0)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThree(x, y, z), x, y, z);
                    break;

                    case 2:
                default:
                    break;
            }
            Console.WriteLine("=============================================================");
            Console.ReadLine();
        }
    }
}
