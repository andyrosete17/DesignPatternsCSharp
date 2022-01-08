namespace CalculatorExampleInteface._1_Command
{
    /// <summary>
    /// The operation command class
    /// </summary>
    public interface IOperations
    {
        /// <summary>
        /// Execute the operation.
        /// </summary>
        void Execute();

        /// <summary>
        /// Gets the inverse of the operation.
        /// </summary>
        /// <value>The inverse of the operation.</value>
        IOperations Inverse { get; }
    }
}