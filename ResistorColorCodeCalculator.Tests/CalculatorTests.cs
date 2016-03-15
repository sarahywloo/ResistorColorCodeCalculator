using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColorCodeCalculator.Logic;

namespace ResistorColorCodeCalculator.Tests {
    /// <summary>
    /// This is to test the resistor calculator
    /// </summary>
    [TestClass]
    public class CalculatorTests {
        //public CalculatorTests() {
        //    //
        //    // TODO: Add constructor logic here
        //    //
        //}

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCalculatorOhmValue() {
            //Arrange
            var calculateOhm = new Calculator();
            //Act
            var result = calculateOhm.CalculatorOhmValue("Yellow", "Violet", "Red", "Gold");
            //Assert
            Assert.AreEqual(4700, result);
        }

        [TestMethod]
        public void TestCalculatorOhmValue2() {
            //Arrange
            var calculateOhm = new Calculator();
            //Act
            var result = calculateOhm.CalculatorOhmValue("Blue", "Gray", "Black", "Gold");
            //Assert
            Assert.AreEqual(68, result);
        }

    }
}
