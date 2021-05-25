namespace ImageLoadExample_2_ConcreteFlyweight
{
    using System;
    using ImageLoadExample_1_BaseImage;

    /// <summary>
    /// The concrete implementation of a shared flyweight instance.
    /// </summary>
    internal class HtmlImage : BaseImage
    {
        // the filename of the image
        protected string _filename;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlyweightPattern.Image"/> class.
        /// </summary>
        /// <param name="filename">The filename of the image.</param>
        public HtmlImage(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// Display the image.
        /// </summary>
        /// <param name="x">The x-coordinate of the position of the image.</param>
        /// <param name="y">The y-coordinate of the position of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public override void Display(int x, int y, int width, int height)
        {
            Console.WriteLine(
                @"<img src=""{0}"" style=""left:{1}px; top:{2}px; width:{3}px; height:{4}px;""/>",
                _filename, x, y, width, height);
        }
    }
}