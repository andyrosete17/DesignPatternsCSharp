namespace EncryptExample_2_ConcreteClass
{
    using EncryptExample_1_AbstractClass;

    /// <summary>
    /// The unencrypted writer class (a concrete class).
    /// </summary>
    internal class UnencryptedWriter : FileWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptExample.UnencryptedWriter"/> class.
        /// </summary>
        /// <param name="path">The path of the file to append.</param>
        public UnencryptedWriter(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Decrypts the file.
        /// </summary>
        protected override void DecryptFile()
        {
        }

        /// <summary>
        /// Encrypts the file.
        /// </summary>
        protected override void EncryptFile()
        {
        }
    }
}