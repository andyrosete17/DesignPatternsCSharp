namespace EncryptExample
{
    using EncryptExample_1_AbstractClass;
    using EncryptExample_2_ConcreteClass;

    /// <summary>
    /// The main program class.
    /// </summary>
    internal class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // append to a des-encrypted file
            FileWriter fw = new DESWriter("encrypted.txt");
            fw.Append("The quick brown fox jumped over the lazy dog.");

            // append to an unencrypted file
            fw = new UnencryptedWriter("unencrypted.txt");
            fw.Append("The quick brown fox jumped over the lazy dog.");
        }
    }
}