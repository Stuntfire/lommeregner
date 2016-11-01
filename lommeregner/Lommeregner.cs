using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lommeregner
{
    class Lommeregner
    {
        public int input1 { get; set; }
        public int input2 { get; set; }
        public string OPR { get; set; }

        public int result;

        //public string input1 = Console.ReadLine();
        //int output2;
        //int number1 = Int32.Parse(input1);


       public int plus()
        {
            result = input1 + input2;
            return result;
        }

        public int minus()
        {
            result = input1 - input2;
            return result;
        }

        public int gange()
        {
            result = input1 * input2;
            return result;
        }

        public int division()
        {
            result = input1 / input2;
            return result;
        }

        public void calculate()
        {          
            if (OPR == "+")
            {
                Console.WriteLine(plus()); 
            }
            else if (OPR == "-")
            {
                Console.WriteLine(minus()); 
            } 
            else if (OPR == "*")
            {
                Console.WriteLine(gange());
            }
            else if (OPR == "/")
            {
                Console.WriteLine(division());
            }
            else Console.WriteLine("Indtast venligst korrekt operator.");
        }



    }
}
