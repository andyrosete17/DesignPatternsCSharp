using System;
using System.Drawing;

namespace CourseImageExample
{
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
			Bitmap = (Bitmap) Image.FromFile ("laptop.png");
		}

		/// <summary>
		/// Clone this course image.
		/// </summary>
		public IClone Clone()
		{
			// create shallow copy, then clone bitmap to create deep copy
			CourseImage clone = (CourseImage) this.MemberwiseClone();
			clone.Bitmap = (Bitmap) Bitmap.Clone ();
			return clone as IClone;
		}

		/// <summary>
		/// Save the bitmap to disk using the given file path.
		/// </summary>
		/// <param name="filePath">The file path to use when saving the bitmap.</param>
		public void Save(string filePath)
		{
			Console.WriteLine ("Writing {0}", filePath);
			Bitmap.Save (filePath);
		}
	}
}
