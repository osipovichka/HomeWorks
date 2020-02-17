using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class CW
    {
        //вывод римскими цифрами
        public string[] romanAlphabet = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        public int[] arabicAlternative = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        public string GetRomanNumber(int number)
        {
            StringBuilder romanNamber = new StringBuilder();

            for (int i = 0; i < romanAlphabet.Length; i++)
            {
                while (number >= arabicAlternative[i])
                {
                    romanNamber.Append(romanAlphabet[i]);
                    number -= arabicAlternative[i];
                }
            }
            return romanNamber.ToString();
        }
    }
}
