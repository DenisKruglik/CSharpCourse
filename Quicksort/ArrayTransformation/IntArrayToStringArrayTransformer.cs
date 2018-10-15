namespace ArrayTransformation
{
    public static class IntArrayToStringArrayTransformer
    {
        public static string[] Transform(this int[] numbers, ITransformer transformer)
        {
            string[] result = new string[numbers.Length];
            int i = 0;
            foreach (int number in numbers)
            {
                result[i++] = transformer.Transform(number);
            }

            return result;
        }
    }
}