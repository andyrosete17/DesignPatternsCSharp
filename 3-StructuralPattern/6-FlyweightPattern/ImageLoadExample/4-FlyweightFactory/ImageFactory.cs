namespace ImageLoadExample_4_FlyweightFactory
{
    using System;
    using System.Collections.Generic;
    using ImageLoadExample_1_BaseImage;
    using ImageLoadExample_2_ConcreteFlyweight;
    using static System.Net.Mime.MediaTypeNames;

    /// <summary>
    /// The flyweight factory class.
    /// </summary>
    internal class ImageFactory
    {
        // a dictionary of cached flyweight instances
        private Dictionary<string, BaseImage> flyweights = new Dictionary<string, BaseImage>();

        /// <summary>
        /// Get a new flyweight instance corresponding to the given filename.
        /// </summary>
        /// <returns>The requested flyweight instance.</returns>
        /// <param name="state">The filename corresponding to the requested flyweight instance.</param>
        public BaseImage GetFlyweight(string filename)
        {
            BaseImage flyweight = null;
            Console.WriteLine();

            // check for cached shared flyweights
            if (flyweights.ContainsKey(filename))
            {
                flyweight = flyweights[filename];
                Console.WriteLine("Returning cached image {0}", filename);
            }
            else
            {
                // create new flyweight and add it to the cache
                flyweight = new HtmlImage(filename);
                flyweights.Add(filename, flyweight);
                Console.WriteLine("Instantiating new image {0}", filename);
            }
            return flyweight;
        }
    }
}