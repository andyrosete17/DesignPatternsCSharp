using System;

namespace TemplateMethodPattern
{
	/// <summary>
	/// The abstract class.
	/// </summary>
	public abstract class AbstractClass
	{
		/// <summary>
		/// The overridable primitive operation 1.
		/// </summary>
		protected abstract void PrimitiveOperation1();

		/// <summary>
		/// The overridable primitive operation 2.
		/// </summary>
		protected abstract void PrimitiveOperation2();

		/// <summary>
		/// The template method that uses the primitive operations.
		/// </summary>
		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
		}
	}
	
}
