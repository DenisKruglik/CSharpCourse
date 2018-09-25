using System;
using NUnit.Framework;

namespace Sorting.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Quicksort_RegularIntArrayPassed_ArrayIsSorted()
        {
            int[] source = new[] {3, 1, 5, 4, 9, 6, 2, 7, 8};

            var p = 0;

            var r = source.Length - 1;

            int[] expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            Sorting.Quicksort(source, p, r);
            
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void Quicksort_BoundOfPartPassed_ArrayIsPartiallySorted()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            var p = 2;

            var r = 5;

            int[] expected = new[] {6, 1, 0, 2, 3, 9, 4, 5, 8, 7};
            
            Sorting.Quicksort(source, p, r);
            
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void Quicksort_LowIsGreaterThanHigh_ArrayStaysTheSame()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            var p = 5;

            var r = 2;

            int[] expected = (int[])source.Clone();
            
            Sorting.Quicksort(source, p, r);
            
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void Quicksort_BoundsOutOfBounds_ThrowsArgumentException()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            Assert.Catch<ArgumentException>(() => Sorting.Quicksort(source, 0, 50));
        }
    }
}