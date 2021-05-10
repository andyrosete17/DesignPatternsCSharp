namespace ChartingLibraryExampleInterface._1_Abstraction
{
    using ChartingLibraryExampleInterface._3_Implementor;

    /// <summary>
    /// The abstraction abstract base class
    /// </summary>
    public abstract class Shape
    {
        // a reference to the implementor instance
        protected IDrawApi _implementor;

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgePattern.Shape"/> class.
        /// </summary>
        /// <param name="implementor">Implementor.</param>
        public Shape(IDrawApi implementor)
        {
            _implementor = implementor;
        }

        /// <summary>
        /// Draw the shape.
        /// </summary>
        public abstract void Draw();
    }
}