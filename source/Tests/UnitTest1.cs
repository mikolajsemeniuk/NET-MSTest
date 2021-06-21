using System;
using System.Threading.Tasks;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        public BussinessLogic logic = new BussinessLogic();
        
        [TestMethod, Priority(2)]
        public void TestAreEqual()
        {
            var x = logic.Calculate(4, 5);
            
            Assert.AreEqual(9, x, $"Expected for '{9}': true; Actual: {x}");
        }

        [TestMethod, Priority(1), TestCategory("CategoryA")]
        public void TestIsTrue()
        {
            var x = logic.Calculate(4, 5);
            bool result = x == 9;
            Assert.IsTrue(result,
                $"Expected for '{9}': true; Actual: {x}");
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 5, 8)]
        public void AdditionTest(int a, int b, int result)
        {
            Assert.AreEqual(result, a + b);
        }

        [TestMethod]
        [DataRow("Check", "Check")]
        [DataRow("Check1", "Check1")]
        public void AdditionTestString(string a, string b) =>
            Assert.AreEqual(a, b, false, $"my message {a}, {b}");


        [TestMethod]
        [DataRow("Check", 1)]
        [DataRow("Check1", 1)]
        public void AdditionTestStringWithInt(string a, int b) =>
            Assert.AreNotSame(a, b);

        [TestMethod]
        public void TestIsFalse()
        {
            var x = logic.Calculate(4, 5);
            bool result = x != 9;
            Assert.IsFalse(result,
                $"Expected for '{9}': true; Actual: {x}");
        }

        [TestMethod]
        public void TestIsException() =>
            // Action actual = () => logic.MyMethodWithError();
            // Assert.ThrowsException<Exception>(actual);
            Assert.ThrowsException<Exception>(() => logic.MyMethodWithError());

        [TestMethod]
        public async Task TestIsExceptionAsync() =>
            await Assert.ThrowsExceptionAsync<Exception>(
                () => logic.MyMethodWithErrorAsync(true)
            );
    }
}
