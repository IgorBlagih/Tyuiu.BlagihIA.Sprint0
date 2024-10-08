using Tyuiu.BlagihIA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BlagihIA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DateServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int [] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubstructionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstructionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultiplicationArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

    }
}