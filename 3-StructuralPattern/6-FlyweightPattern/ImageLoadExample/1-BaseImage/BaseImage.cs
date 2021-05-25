namespace ImageLoadExample_1_BaseImage
{
    /// <summary>
    /// The flyweight abstract class. The extrinsic state 
    /// </summary>
    internal abstract class BaseImage
    {
        /// <summary>
        /// Display the image.
        /// </summary>
        /// <param name="x">The x-coordinate of the position of the image.</param>
        /// <param name="y">The y-coordinate of the position of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public abstract void Display(int x, int y, int width, int height);
    }
}