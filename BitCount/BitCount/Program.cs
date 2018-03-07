using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCount
{
    public static class BitCounter
    {

        public static int countBits (int what)
        {
            int bitnum = 0;
            uint uwhat = unchecked((uint)what);
            while (uwhat != 0)
            {
                bitnum += (int)(uwhat & 1);
                uwhat = uwhat >> 1;
            }
            return bitnum;
        }

        // parity control
        public static string ParityControl(string input)
        {
            string[] newInp = input.Split(' ');
            StringBuilder outp = new StringBuilder();
            foreach (string num in newInp)
            {
                outp.Append( countBits(int.Parse(num)) % 2 == 0 ? Convert.ToString( (char)(int.Parse(num) & 127) ) : "");
            }
            return (outp.ToString());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BitCounter.ParityControl(Console.ReadLine());
        }
    }
}
