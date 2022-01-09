namespace RpnExample
{
    using System.Collections.Generic;
    using RpnExample_1_AbstractExpression;
    using RpnExample_2_TerminalExpression;
    using RpnExample_3_NonTerminalExpression;

    /// <summary>
    /// The evaluator parser class.
    /// </summary>
    public class Evaluator
    {
        /// <summary>
        /// Parse the specified text and return an expression tree.
        /// </summary>
        /// <param name="text">The text to parse.</param>
        /// <returns>The expression tree corresponding to the parsed text.</returns>
        public RpnExpression Parse(string text)
        {
            // set up an expression stack
            Stack<RpnExpression> stack = new Stack<RpnExpression>();

            // parse the text
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                RpnExpression lhs = null, rhs = null;
                switch (word)
                {
                    case "+":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Add(lhs, rhs));
                        break;

                    case "-":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Substract(lhs, rhs));
                        break;

                    case "*":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Multiply(lhs, rhs));
                        break;

                    case "/":
                        rhs = stack.Pop();
                        lhs = stack.Pop();
                        stack.Push(new Divide(lhs, rhs));
                        break;

                    default:
                        int number = int.Parse(word);
                        stack.Push(new Number(number));
                        break;
                }
            }

            // return expression tree
            return stack.Pop();
        }
    }
}