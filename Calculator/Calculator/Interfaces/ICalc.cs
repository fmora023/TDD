namespace Calculator.Interfaces
{
    /// <summary>
    /// Interface for Calculator implementation
    /// </summary>
    public interface ICalc
    {
        /// <summary>
        /// Sums the specified values.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns> value1 plus value2 result.</returns>
        int Sum(int value1, int value2);

        /// <summary>
        /// Mults the specified value1.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>the result of mult the parms</returns>
        int Mult(int value1, int value2);
    }
}
