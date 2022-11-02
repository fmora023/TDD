using Calculator.Interfaces;

namespace Calculator
{
    public class Calc : ICalc
    {
        /// <summary>
        /// Mults the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// the result of mult the parms
        /// </returns>
        public int Mult(int value1, int value2)
        {
            return value1 * value2;
        }

        /// <summary>
        /// Sums the specified values.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// value1 plus value2 result.
        /// </returns>
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
