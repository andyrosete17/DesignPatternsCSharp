namespace ChartingLibraryExampleInterface._3_Implementor
{
    /// <summary>
    /// The implementor abstract base class.
    /// </summary>
    public interface IDrawApi
    {
        /// <summary>
        /// Draw a single straight line.
        /// </summary>
        /// <param name="x1">The x coordinate of the line origin.</param>
        /// <param name="y1">The y coordinate of the line origin.</param>
        /// <param name="x2">The x coordinate of the line endpoint.</param>
        /// <param name="y2">The y coordinate of the line endpoint.</param>
        void DrawLine(int x1, int y1, int x2, int y2);
    }
}