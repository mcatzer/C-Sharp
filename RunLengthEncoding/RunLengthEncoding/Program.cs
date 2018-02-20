using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public class RunLengthEncoding
    {
        public string Encode(string inpLine)
        {
            try
            {
                int count = 1;
                char prevchar = char.MinValue;
                List<string> lst = new List<string>();
                foreach (char character in inpLine)
                {
                    if (!character.Equals(prevchar))
                    {
                        if (!prevchar.Equals(char.MinValue))
                        {
                            if (count > 1)
                                lst.Add(count.ToString());
                            lst.Add(prevchar.ToString());
                        }
                        count = 1;
                        prevchar = character;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count > 1)
                    lst.Add(count.ToString());
                if (inpLine.Length > 0)
                    lst.Add(prevchar.ToString());
                return string.Join("", lst.ToArray());
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception in RLE encoding:" + exc.Message);
                return null;
            }
            
        }

        public string Decode(string inpLine)
        {
            try
            {
                int count = 0;
                List<string> lst = new List<string>();

                foreach (char character in inpLine)
                {
                    if (char.IsDigit(character))
                        count = count * 10 + (int)char.GetNumericValue(character);
                    else
                    {
                        if (count>0)
                            for (int i = 0; i < count; i++)
                            {
                                lst.Add(character.ToString());
                            }
                        else
                            lst.Add(character.ToString());
                        count = 0;
                    }
                }

                return string.Join("", lst.ToArray());
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception in RLE decoding:" + exc.Message);
                return null;
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}
