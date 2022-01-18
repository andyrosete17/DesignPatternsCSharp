namespace CourseImageExampleInterface_2_ConcretePrototype
{
    using System;
    using System.Drawing;
    using CourseImageExampleInterface_1_Prototype;

    /// <summary>
    /// The concrete course image template class
    /// </summary>
    public class CourseImage : IClone
    {
        // the bitmap holding the course image
        public Bitmap Bitmap { get; set; }

        /// <summary>
        /// Initialise the course image.
        /// </summary>
        public void Initialise()
        {
            // load generic laptop image
            Bitmap = (Bitmap)Image.FromFile("laptop.png");
        }

        /// <summary>
        /// Clone this course image.
        /// </summary>
        public IClone Clone()
        {
            // create shallow copy (the copy refers to the same image as the prototype),
            // if we try to do any modifications to the clone, we will be also modifying the prototype image
            CourseImage clone = (CourseImage)this.MemberwiseClone();

            // then clone bitmap to create deep copy (duplicate of the base map and assign it to the copy)
            // now both the prototype and the copy refer to unique and separate images
            clone.Bitmap = (Bitmap)Bitmap.Clone();
            return clone;
        }

        /// <summary>
        /// Save the bitmap to disk using the given file path.
        /// </summary>
        /// <param name="filePath">The file path to use when saving the bitmap.</param>
        public void Save(string filePath)
        {
            Console.WriteLine("Writing {0}", filePath);
            Bitmap.Save(filePath);
        }
    }
}