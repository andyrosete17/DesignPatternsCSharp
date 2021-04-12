using System;
using System.Drawing;

namespace ToyFactoryExample
{
    /// <summary>
    /// The abstract toy product class.
    /// </summary>
    public interface IToy
    {
        /// <summary>
        /// Gets the required quantity of plastic powder.
        /// </summary>
        /// <returns>The required powder quantity in grams.</returns>
        int GetPowderQuantity();

        /// <summary>
        /// Gets the required heating time.
        /// </summary>
        /// <returns>The required heating time.</returns>
        TimeSpan GetHeatingTime();

        /// <summary>
        /// Gets the required paint color.
        /// </summary>
        /// <returns>The required paint color.</returns>
        Color GetColor();
    }
}