namespace InterpreterPattern_3_NonTerminalExpression
{
    using InterpreterPattern_1_AbstractExpression;
    using InterpreterPattern_4_Context;

    /// <summary>
    /// The nonterminal expression class.
    /// </summary>
    internal class NonterminalExpression : AbstractExpression
    {
        // DEMO: this nonterminal expression has a left-hand and a right-hand subexpression
        protected AbstractExpression _lhs = null;

        protected AbstractExpression _rhs = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InterpreterPattern.NonterminalExpression"/> class.
        /// </summary>
        /// <param name="lhs">The left-hand side subexpression.</param>
        /// <param name="rhs">The right-hand side subexpression.</param>
        public NonterminalExpression(AbstractExpression lhs, AbstractExpression rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        /// <summary>
        /// Interpret the expression.
        /// </summary>
        /// <param name="context">The expression context to use.</param>
        /// <returns>The expression result (an integer in this example).</returns>
        public override int Interpret(Context context)
        {
            // DEMO: this nonterminal expression implements an addition
            return _lhs.Interpret(context) + _rhs.Interpret(context);
        }
    }
}