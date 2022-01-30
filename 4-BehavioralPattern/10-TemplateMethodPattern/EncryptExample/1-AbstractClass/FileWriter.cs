namespace EncryptExample_1_AbstractClass
{
    using System.IO;

    /// <summary>
    /// The filewriter class (the abstract class).
    /// </summary>
    public abstract class FileWriter
    {
        // the path of the file
        protected string _path = null;

        /// <summary>
        /// Decrypts the file.
        /// </summary>
        protected abstract void DecryptFile();

        /// <summary>
        /// Appends data to the file.
        /// </summary>
        /// <param name="data">The data to append.</param>
        protected virtual void AppendFile(string data)
        {
            using (FileStream fs = File.Open(_path, FileMode.Append))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.Write(data);
                }
            }
        }

        /// <summary>
        /// Encrypts the file.
        /// </summary>
        protected abstract void EncryptFile();

        /// <summary>
        /// Append data to the file.
        /// </summary>
        public void Append(string data)
        {
            DecryptFile();
            AppendFile(data);
            EncryptFile();
        }
    }
}