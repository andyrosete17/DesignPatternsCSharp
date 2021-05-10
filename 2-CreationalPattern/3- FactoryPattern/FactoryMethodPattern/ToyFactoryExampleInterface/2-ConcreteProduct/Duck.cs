using System;
using System.Drawing;

namespace ToyFactoryExample
{
    /// <summary>
    /// The concrete duck product class.
    /// </summary>
    internal class Duck : IToy
    {
        /// <summary>
        /// Gets the required quantity of plastic powder.
        /// </summary>
        /// <returns>The required powder quantity in grams.</returns>
        public int GetPowderQuantity()
        {
            return 20;
        }

        /// <summary>
        /// Gets the required heating time.
        /// </summary>
        /// <returns>The required heating time.</returns>
        public TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(1);
        }

        /// <summary>
        /// Gets the required paint color.
        /// </summary>
        /// <returns>The required paint color.</returns>
        public Color GetColor()
        {
            return Color.Yellow;
        }
    }
}