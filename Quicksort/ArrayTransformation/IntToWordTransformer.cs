using System.Collections.Generic;

namespace ArrayTransformation
{
    public class IntToWordTransformer: ITransformer
    {
        private static Dictionary<int, string> digitToWord = new Dictionary<int, string>()
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {0, "zero"}
        };
        
        public string Transform(int number)
        {
            List<string> result = new List<string>();
            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number = -number;
            }

            while (number > 0)
            {
                var remainder = number % 10;
                result.Add(digitToWord[remainder]);
                number /= 10;
            }

            if (isNegative)
            {
                result.Add("minus");
            }

            result.Reverse();
            return string.Join(" ", result);
        }
    }
}