namespace InterpreterPattern
{
    using System;
    using InterpreterPattern_1_AbstractExpression;
    using InterpreterPattern_2_TerminalExpression;
    using InterpreterPattern_3_NonTerminalExpression;
    using InterpreterPattern_4_Context;

    /// <summary>
    /// The main program class.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // instantiate a new context
            Context context = new Context();

            // build a simple expression tree (usually a parser does this)
            // this expression tree represents the expression: '4+3'
            AbstractExpression tree =
                new NonterminalExpression(
                new TerminalExpression(4),
                new TerminalExpression(3));

            // interpret the expression
            Console.WriteLine("Result: {0}", tree.Interpret(context));
        }
    }
}