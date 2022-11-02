namespace CalculatorTest
{
    using System;
    using Calculator;
    using Calculator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test Class for calculator
    /// 
    /// BDD Behavior Driven Development
    ///     given (some context)
    ///     when(something happens)
    ///     then(outcome)
    /// </summary>
    /// <seealso cref="CalculatorTest.BaseFeature" />
    [TestClass]
    public class CalcTest : BaseFeature
    {
        /// <summary>
        /// Tests the sum.
        /// </summary>
        [TestMethod]
        public void TestSum()
        {
            this.RunScenario(
                given => this.ACalculator(),
                when => this.Sum(5, 4),
                then => this.VerifyResult<int>(9));
        }

        /// <summary>
        /// Tests the mult.
        /// </summary>
        [TestMethod]
        public void TestMult()
        {
            this.RunScenario(
                given => this.ACalculator(),
                when => this.Mult(5, 4),
                then => this.VerifyResult<int>(20));
        }

        private void Sum(int value1, int value2)
        {
            var calc = this.Scenario.Get<ICalc>(this.Calculator);
            this.Scenario[this.Result] = calc.Sum(value1, value2);
        }

        private void Mult(int value1, int value2)
        {
            var calc = this.Scenario.Get<ICalc>(this.Calculator);
            this.Scenario[this.Result] = calc.Mult(value1, value2);
        }

        private void ACalculator()
        {
            this.Scenario[this.Calculator] = new Calc();
        }
    }
}
