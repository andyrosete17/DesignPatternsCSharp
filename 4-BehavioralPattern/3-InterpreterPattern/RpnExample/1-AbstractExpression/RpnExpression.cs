namespace RpnExample_1_AbstractExpression
{
    /// <summary>
    /// The abstract RPN expression class.
    /// </summary>
    public abstract class RpnExpression
    {
        /// <summary>
        /// Interpret the expression.
        /// </summary>
        /// <returns>The expression result.</returns>
        public abstract int Interpret();
    }
}