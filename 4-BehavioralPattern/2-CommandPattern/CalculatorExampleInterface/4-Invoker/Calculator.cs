namespace CalculatorExampleInteface._4_Invoker
{
    using System.Collections.Generic;
    using CalculatorExampleInteface._1_Command;

    /// <summary>
    /// The calculator invoker class.
    /// </summary>
    public class Calculator
    {
        // the undo command stack
        protected Stack<IOperations> undoStack = new Stack<IOperations>();

        /// <summary>
        /// Invoke the specified operation.
        /// </summary>
        /// <param name="operation">the operation to invoke.</param>
        public void Invoke(IOperations operation)
        {
            operation.Execute();
            undoStack.Push(operation);
        }

        /// <summary>
        /// Undo the last operation.
        /// </summary>
        public void Undo()
        {
            var operation = undoStack.Pop();
            operation.Inverse.Execute();
        }
    }
}