namespace RpnExample_2_TerminalExpression
{
    using RpnExample_1_AbstractExpression;

    /// <summary>
    /// The number terminal expression class.
    /// </summary>
    internal class Number : RpnExpression
    {
        // the value of the number
        protected int _value = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="RpnExample.Number"/> class.
        /// </summary>
        /// <param name="value">The value of the number.</param>
        public Number(int value)
        {
            _value = value;
        }

        /// <summary>
        /// Interpret the expression.
        /// </summary>
        /// <returns>The expression result.</returns>
        public override int Interpret()
        {
            return _value;
        }
    }
}