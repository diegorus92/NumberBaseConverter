using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberBaseConverter
{
    public class BaseConverter
    {

        private string ConvertToString(List<int>list)
        {
            string result = "";

            foreach(var i in list)
            {
                result += i;
            }

            return result;
        }

        public static long FromBinaryToDecimal(long binary_number)
        {
            string bin = binary_number.ToString();
            int BASE = 2;
            long acum = 0;
            int positions = bin.Length - 1;

            foreach (var i in bin)
            {
                acum += (long) (Int32.Parse(i.ToString()) * (Math.Pow(BASE, positions)));
                positions--;
            }


            return acum;
        }

        public static string FromDecimalToBinary(int decimal_number)
        {
            int dividend = decimal_number;
            int DIVISOR = 2;
            List<int> acum = new List<int>();
            int tempMod = 0;

            switch (dividend)
            {
                case 0:
                    {
                        acum.Add(0);
                        return acum[0].ToString();
                    }
                case 1:
                    {
                        acum.Add(1);
                        return acum[0].ToString();
                    }
                default:
                    {
                        while (dividend >= DIVISOR)
                        {
                            tempMod = (dividend % DIVISOR);
                            dividend = dividend / DIVISOR;
                            acum.Add(tempMod);
                            if (dividend < DIVISOR)
                            {
                                acum.Add(dividend);
                            }
                        }

                        acum.Reverse();
                        string result = "";
                        foreach (var i in acum)
                        {
                            result += i;
                        }
                        return result;
                    }
            }
        }
    }
}
