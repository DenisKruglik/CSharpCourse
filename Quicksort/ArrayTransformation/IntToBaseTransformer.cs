using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ArrayTransformation
{
    public class IntToBaseTransformer: ITransformer
    {
        
        private static int MIN_BASE = 2;

        private static int MAX_BASE = 16;
        
        private static Dictionary<int, string> numberToHex = new Dictionary<int, string>()
        {
            {10, "A"},
            {11, "B"},
            {12, "C"},
            {13, "D"},
            {14, "E"},
            {15, "F"}
        };

        private int _baze = -1;

        public int GetBase()
        {
            return _baze;
        }

        public void SetBase(int bazze)
        {
            if (bazze < MIN_BASE || bazze > MAX_BASE)
            {
                throw new ArgumentException("Base to be set is not correct");
            }

            _baze = bazze;
        }
        
        public string Transform(int number)
        {
            if (_baze < 0)
            {
                throw new InvalidDataException("Base must be set before using");
            }
            StringBuilder result = new StringBuilder();
            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number = -number;
            }

            while (number > 0)
            {
                var remainder = number % _baze;
                if (remainder < 10)
                {
                    result.Append(remainder.ToString());
                }
                else
                {
                    result.Append(numberToHex[remainder]);
                }

                number /= _baze;
            }

            if (isNegative)
            {
                result.Append("-");
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}