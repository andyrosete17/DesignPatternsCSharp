namespace RpnExample_3_NonTerminalExpression
{
    using RpnExample_1_AbstractExpression;

    /// <summary>
    /// The nonterminal multiply expression class.
    /// </summary>
    internal class Multiply : RpnExpression
    {
        // the left-hand and right-hand subexpressions
        protected RpnExpression _lhs = null;

        protected RpnExpression _rhs = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RpnExample.Multiply"/> class.
        /// </summary>
        /// <param name="lhs">The left-hand side subexpression.</param>
        /// <param name="rhs">The right-hand side subexpression.</param>
        public Multiply(RpnExpression lhs, RpnExpression rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        /// <summary>
        /// Interpret the expression.
        /// </summary>
        /// <returns>The expression result.</returns>
        public override int Interpret()
        {
            return _lhs.Interpret() * _rhs.Interpret();
        }
    }
}