using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Rails
    {
        int key;
        string input;

        public Rails(int key, string input)
        {
            this.key = key;
            this.input = input;
        }

        
        int _lineCount = 0;
        int _columnsCount = 0;

        public string Deshifr()
        {
            string inp = input;
            _lineCount = input.Count(f => f == ' ') + 1;
            string[] words = input.Split(new char[] { ' ' });
            int strIndex = 0, direction = 1;
            string processingWord = words[strIndex];
            Console.Write(words[0][0]);
            words[strIndex] = processingWord.Remove(0, 1);

            StringBuilder result = new StringBuilder();

            for (int j = 0; j < input.Length - _lineCount; j++)
            {
                strIndex += direction;
                processingWord = words[strIndex];

                words[strIndex] = processingWord.Remove(0, 1);
                result.Append(processingWord[0]);
                if (strIndex == _lineCount - 1 || strIndex == 0)
                {
                    direction *= -1;
                }
            }
            return input[0] +result.ToString();
        }

        public string Shifr()
        {
            _lineCount = key;
            string correctedString = Regex.Replace(input, "[ -.?!)(,;:']", "");
            _columnsCount = (correctedString.Length);

            string[,] nums3 = new string[_lineCount, _columnsCount];
            int PoryadokStr = 0, strNumber = 0, direction = 1;
            for (int j = 0; j < _columnsCount; j++)
            {
                nums3[strNumber, j] = correctedString[PoryadokStr].ToString();
                strNumber += direction;
                if (strNumber == _lineCount - 1 || strNumber == 0)
                {
                    direction *= -1;
                }
                PoryadokStr++;
            }
            StringBuilder sresult = new StringBuilder();

            for (int i = 0; i < _lineCount; i++)
            {
                for (int j = 0; j < _columnsCount; j++)
                {
                    sresult.Append(nums3[i, j]);
                }
                sresult.Append(' ');
            }
            return sresult.ToString();
        }

    }
}
