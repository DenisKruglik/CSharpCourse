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

            int[] expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            Sorting.Quicksort(source);
            
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
        public void Quicksort_LowIsGreaterThanHigh_ThrowsArgumentException()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            var p = 5;

            var r = 2;
            
            Assert.Catch<ArgumentException>(() => Sorting.Quicksort(source, p, r));
        }

        [Test]
        public void Quicksort_BoundsOutOfBounds_ThrowsArgumentException()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            Assert.Catch<ArgumentException>(() => Sorting.Quicksort(source, 0, 50));
        }

        [Test]
        public void Quicksort_ArrayIsNull_ThrowsArgumentNullException()
        {
            int[] source = null;

            Assert.Catch<ArgumentNullException>(() => Sorting.Quicksort(source));
        }

        [Test]
        public void MergeSort_RegularIntArrayPassed_ArrayIsSorted()
        {
            int[] source = new[] {3, 1, 5, 4, 9, 6, 2, 7, 8};

            int[] expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            Sorting.MergeSort(source);
            
            Assert.AreEqual(expected, source);
        }
        
        [Test]
        public void MergeSort_BoundOfPartPassed_ArrayIsPartiallySorted()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            var p = 2;

            var r = 5;

            int[] expected = new[] {6, 1, 0, 2, 3, 9, 4, 5, 8, 7};
            
            Sorting.MergeSort(source, p, r);
            
            Assert.AreEqual(expected, source);
        }

        [Test]
        public void MergeSort_LowIsGreaterThanHigh_ThrowsArgumentException()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            var p = 5;

            var r = 2;
            
            Assert.Catch<ArgumentException>(() => Sorting.MergeSort(source, p, r));
        }

        [Test]
        public void MergeSort_BoundsOutOfBounds_ThrowsArgumentException()
        {
            int[] source = new[] {6, 1, 9, 3, 2, 0, 4, 5, 8, 7};

            Assert.Catch<ArgumentException>(() => Sorting.MergeSort(source, 0, 50));
        }

        [Test]
        public void MergeSort_ArrayIsNull_ThrowsArgumentNullException()
        {
            int[] source = null;

            Assert.Catch<ArgumentNullException>(() => Sorting.MergeSort(source));
        }
    }
}