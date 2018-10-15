using System;
using NUnit.Framework;

namespace ArrayTransformation.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TransformToBase_NumberArrayAnd16Passed_HexStringsArrayReturned()
        {
            int[] source = { 23, 504, -1 };

            string[] expected = { "17", "1F8", "-1" };
            
            var baseTransformer = new IntToBaseTransformer();
            baseTransformer.SetBase(16);

            var actual = source.Transform(baseTransformer);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TransformToWords_NumberArrayPassed_WordsArrayReturned()
        {
            int[] source = { 23, 504, -1 };
            
            string[] expected = { "two three", "five zero four", "minus one" };

            var actual = source.Transform(new IntToWordTransformer());
            Assert.AreEqual(expected, actual);
        }
    }
}