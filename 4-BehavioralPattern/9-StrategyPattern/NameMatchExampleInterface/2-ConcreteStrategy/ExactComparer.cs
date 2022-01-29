namespace NameMatchExampleInterface_2_ConcreteStrategy
{
    using NameMatchExampleInterface_1_NameComparer;

    /// <summary>
    /// The exact comparer class (a concrete strategy).
    /// </summary>
    public class ExactComparer : INameComparer
    {
        /// <summary>
        /// Compare the specified name and database record.
        /// </summary>
        /// <param name="name">The name to compare.</param>
        /// <param name="record">The database record to compare against.</param>
        public bool Compare(string name, FullName record)
        {
            // match exact
            string recordName = record.FirstName + " " + record.LastName;
            return name == recordName;
        }
    }
}