using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForCalculator
{
    [TestClass]
    public class Buttons
    {
        [TestMethod]
        public void AddSympbolInTBMain_AddNumbers_NumberExist()
        {
            //arrange
            char[] forSend = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string expected = "1234567890";
            MainWindow main = new MainWindow();
            string actual = null;
            //act
            foreach (char ch in forSend)
            {
                main.AddSympbolInTBMain(ch);
                actual = main.Main.Text;
            }

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
