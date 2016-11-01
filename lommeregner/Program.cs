using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
             Lommeregner lommeregner = new Lommeregner();

            Console.WriteLine("Intast første tal");
            string input1 = Console.ReadLine();
            lommeregner.input1 = Int32.Parse(input1);

            Console.WriteLine("Intast operator: ");
            string OPR = Console.ReadLine();
            lommeregner.OPR = OPR;

            Console.WriteLine("Intast næste tal");
            string input2 = Console.ReadLine();
            lommeregner.input2 = Int32.Parse(input2);


            //The result
            lommeregner.calculate();

        
            

            //Console.WriteLine($"Result is: {lommeregner.plus()}  ");
            //Console.WriteLine($"Result is: {lommeregner.minus()}  ");
            //Console.WriteLine($"Result is: {lommeregner.gange()}  ");
            //Console.WriteLine($"Result is: {lommeregner.division()}  ");
            //int output2;
            //int number1 = Int32.Parse(input1);



            //int tal1 = lommeregner.input("1");

            //int tal2 = lommeregner.input("1");

            //Console.WriteLine($"The result is {tal1+tal2}");
        }
    }
}
