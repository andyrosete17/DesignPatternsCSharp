namespace ImageLoadExampleInterface_5_Client
{
    using ImageLoadExampleInterface_4_FlyweightFactory;

    /// <summary>
    /// The client class.
    /// </summary>
    public class WebPageRenderer
    {
        /// <summary>
        /// Perform a render operation.
        /// </summary>
        public void Render()
        {
            // instantiate an image factory
            var factory = new ImageFactory();

            // display image
            var image = factory.GetFlyweight("image.png");
            image.Display(0, 0, 400, 250);

            // display another image
            image = factory.GetFlyweight("image.png");
            image.Display(60, 420, 200, 90);

            // display another image
            image = factory.GetFlyweight("image.png");
            image.Display(65, 925, 75, 75);
        }
    }
}