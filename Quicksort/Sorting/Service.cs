using System;

namespace Sorting
{
    public class Service
    {
        public static void sortWith(int[] array, string sorting)
        {
            object[] arguments = {array, 0, array.Length - 1};
            Type sortingClass = Type.GetType("Sorting.Sorting");
            sortingClass.GetMethod(sorting).Invoke(null, arguments);
        }
    }
}