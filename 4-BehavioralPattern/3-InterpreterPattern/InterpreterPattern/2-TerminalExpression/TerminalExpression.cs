namespace InterpreterPattern_2_TerminalExpression
{
    using InterpreterPattern_1_AbstractExpression;
    using InterpreterPattern_4_Context;

    /// <summary>
    /// The terminal expression class.
    /// </summary>
    internal class TerminalExpression : AbstractExpression
    {
        // DEMO: this terminal expression represents a literal value
        protected int _value = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterpreterPattern.TerminalExpression"/> class.
        /// </summary>
        /// <param name="value">DEMO: this terminal expression represents a literal value.</param>
        public TerminalExpression(int value)
        {
            _value = value;
        }

        /// <summary>
        /// Interpret the expression.
        /// </summary>
        /// <param name="context">The expression context to use.</param>
        /// <returns>The expression result (an integer in this example).</returns>
        public override int Interpret(Context context)
        {
            return _value;
        }
    }
}