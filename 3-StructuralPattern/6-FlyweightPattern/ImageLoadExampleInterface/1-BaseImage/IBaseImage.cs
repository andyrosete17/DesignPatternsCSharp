namespace ImageLoadExampleInterface_1_BaseImage
{
    /// <summary>
    /// The flyweight interface. The extrinsic state 
    /// </summary>
    public interface IBaseImage
    {
        /// <summary>
        /// Display the image.
        /// </summary>
        /// <param name="x">The x-coordinate of the position of the image.</param>
        /// <param name="y">The y-coordinate of the position of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        void Display(int x, int y, int width, int height);
    }
}