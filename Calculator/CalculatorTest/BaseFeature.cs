namespace CalculatorTest
{
    using System;
    using System.Linq.Expressions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mobilize.Quality.Test;

    /// <summary>
    /// Base class for Test classes
    /// </summary>
    public class BaseFeature : Feature
    {
        /// <summary>
        /// Gets the result string.
        /// </summary>
        /// <value>
        /// The result string.
        /// </value>
        internal string Result => "result";

        /// <summary>
        /// Gets the calculator string.
        /// </summary>
        /// <value>
        /// The calculator string.
        /// </value>
        internal string Calculator => "calc";

        /// <summary>
        /// Runs the scenario.
        /// </summary>
        /// <param name="steps">The steps.</param>
        protected override void RunScenario(params Expression<Action<Step>>[] steps)
        {
            this.Setup();
            base.RunScenario(steps);
        }

        /// <summary>
        /// Setups this instance.
        /// </summary>
        protected virtual void Setup()
        {
            // add override in class to custom setup
        }

        /// <summary>
        /// Verifies the result.
        /// </summary>
        /// <typeparam name="T">result type.</typeparam>
        /// <param name="expected">The expected.</param>
        protected void VerifyResult<T>(T expected)
        {
            var result = this.Scenario.Get<T>(this.Result);
            Assert.AreEqual(expected, result);
        }
    }
}
