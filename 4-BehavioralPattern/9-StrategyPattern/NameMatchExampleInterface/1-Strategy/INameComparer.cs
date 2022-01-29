namespace NameMatchExampleInterface_1_NameComparer
{
    /// <summary>
    /// The FullName structure holding one database record.
    /// </summary>
    public struct FullName
    {
        public string FirstName;
        public string LastName;

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    /// <summary>
    /// The abstract name comparer class (the strategy).
    /// </summary>
    public interface INameComparer
    {
        /// <summary>
        /// Compare the specified name and databaseRecord.
        /// </summary>
        /// <param name="name">The name to compare.</param>
        /// <param name="record">The database record to compare against.</param>
        bool Compare(string name, FullName record);
    }
}