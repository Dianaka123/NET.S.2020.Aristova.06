using NET.S._2020.Aristova._06;
using NUnit.Framework;

namespace TestingMethod
{
    public class SortMethodsTest
    {
        [Test]
        public void BubbleSortBySummary_1234567_1273456()
        {
            int[][] array = new[]
            {
                new[] {1, 2},
                new[] {3, 4, 5, 6},
                new[] {7}
            };

            int[][] expectedArray = new[]
            {
                new[] {3, 4, 5, 6},
                new[] {7},
                new[] {1, 2}

            };

            SortMethods.BubbleSortBySummary(array);

            Assert.AreEqual(array, expectedArray);
        }

        [Test]
        public void BubbleSortByMaxElement_1234567_1273456()
        {
            int[][] array = new[]
            {
                new[] {7},

                new[] {1, 2},
                new[] {3, 4, 5, 6},
            };

            int[][] expectedArray = new[]
            {
                new[] {7},
                new[] {3, 4, 5, 6},
                new[] {1, 2}

            };

            SortMethods.BubbleSortByMaxElement(array);

            Assert.AreEqual(array, expectedArray);
        }

        [Test]
        public void BubbleSortByMinElement_1234567_1273456()
        {
            int[][] array = new[]
            {
                new[] { 7, 1, 2},
                new[] {3, 4, 5, 6},
                new[] {0}
            };

            int[][] expectedArray = new[]
            {
                new[] {3, 4, 5, 6},
                new[] {7, 1, 2},
                new[] {0},

            };

            SortMethods.BubbleSortByMinElement(array);

            Assert.AreEqual(array, expectedArray);
        }
    }

}