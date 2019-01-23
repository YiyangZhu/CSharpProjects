using NUnit.Framework;
using System;
namespace UnitTestProject1
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual(10, 1,"I expect the two numbers are equal.");
        }

        public void test()
        {
            var groceryList = new string[4];
            groceryList[0] = "Milk";
            groceryList[1] = "Cheese";
            groceryList[2] = "Eggs";
            groceryList[3] = "Apples";
            groceryList[4] = "Eggplant";
            var groceryList1 = new string[4] {"Milk","egg","cheese","do not know" };
            Array.Resize(ref groceryList, 6);

        }

        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[1], "Milk");
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }

    }
}
