namespace MyCollectionExample_2_ConcreteAggregate
{
    using System.Collections;
    using System.Collections.Generic;
    using MyCollectionExample_1_ConcreteIterator;

    /// <summary>
    /// The concrete aggregate class, called an 'Enumerable' in dotNet.
    /// </summary>
    public class MyCollection : IEnumerable<int>
    {
        // DEMO: provide three interal fields that the enumerator will access sequentially
        internal int fieldA = 0;

        internal int fieldB = 0;
        internal int fieldC = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyCollectionExample.MyCollection"/> class.
        /// </summary>
        /// <param name="a">The value for field A.</param>
        /// <param name="b">The value for field B.</param>
        /// <param name="c">The value for field C.</param>
        public MyCollection(int a, int b, int c)
        {
            fieldA = a;
            fieldB = b;
            fieldC = c;
        }

        // explicitly implement the non-generic IEnumerable interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            // defer to the generic IEnumerable<T> implementation
            return this.GetEnumerator();
        }

        /// <summary>
        /// Gets the enumerator for sequentially accessing elements.
        /// </summary>
        /// <returns>The enumerator to sequentially access elements.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return new MyCollectionEnumerator(this);
        }
    }
}