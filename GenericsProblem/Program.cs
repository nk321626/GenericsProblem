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
        public static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome to Generic Problem==========");
            Console.WriteLine("\t->Please Select the Option Which can be Executed<-");
<<<<<<< HEAD
            Console.WriteLine("\t1. Find Max Value Out Of Three(Int Value) \n\t2. Find Max Value Out Of Three(Double value) \n\t3 Exit");
=======
            Console.WriteLine("\t1. FindMaxValueOutOfThree \n\t2. Find Max Value Out of Three Double \n\t3 Find Max Value Out of Three String \n\"4 Exit");
>>>>>>> UC3_GivenThreeStringFindMax
            Console.Write("\tEnter The Selected Option: ");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int x = 40, y = 30, z = 10;
<<<<<<< HEAD
                    
=======

>>>>>>> UC3_GivenThreeStringFindMax
                    if (Generic.FindMaxValueOutOfThree(x, y, z) != 0)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThree(x, y, z), x, y, z);
                    break;

<<<<<<< HEAD
=======
                   
>>>>>>> UC3_GivenThreeStringFindMax

                    case 2:
                    double p = 20.53, q = 42.75, r = 82.22;
                    if (Generic.FindMaxValueOutOfThreedouble(p, q, r) != 0)
<<<<<<< HEAD
                    
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThreedouble(p, q, r), p, q, r);
                    break;                    
=======
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThreedouble(p, q, r), p, q, r);
                    break;
                    
                case 3:
                    string s = "abc", t = "pqr", u = "xyz";
                    if (Generic.FindMaxValueOutOfThreestring(s, t, u) != null)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThreestring(s, t, u), s, t, u);
                    break;
>>>>>>> UC3_GivenThreeStringFindMax
                default:
                    break;
            }
            Console.WriteLine("=============================================================");
            Console.ReadLine();
        }
    }
}