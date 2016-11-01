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


        public int input(string input)
        {
            int number = Int32.Parse(input);
            return number;
        }
    }
}
