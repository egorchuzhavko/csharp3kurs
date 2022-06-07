using ModulTest;
using NUnit.Framework;
using System.Linq;

namespace UnitTest1
{
    public class Tests
    {
        double[,] arr;
        Sort p;
        [SetUp]
        public void SetUp()
        {
            p = new Sort(3);
            arr = new double[3, 3] { {2,3,6}, {7,2,1}, {9,3,8} };
        }

        [Test]
        public void Max()
        {

            double[] expected = { 6, 7, 9 };
            double[] actuale = p.Max(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void Sum()
        {

            double expected = 12;
            double actuale = p.Sum(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void SumFull()
        {

            double expected = 41;
            double actuale = p.SumFull(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void Min()
        {

            double[] expected = { 2, 1, 3 };
            double[] actuale = p.Min(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void Max_Chetn()
        {

            double expected = 4;
            double actuale = p.Max_Chetn(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void Chetn_MaximZnach()
        {

            double expected = 4;
            double actuale = p.Max_Chetn(arr);
            Assert.AreEqual(actuale, expected);
        }
        [Test]
        public void SumArr()
        {

            double expected = 41;
            double actuale = p.SumFull(arr);
            Assert.AreEqual(actuale, expected);
        }
    }
}