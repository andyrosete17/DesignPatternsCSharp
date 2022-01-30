namespace EncryptExample_2_ConcreteClass
{
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using EncryptExample_1_AbstractClass;

    /// <summary>
    /// The DES writer class (a concrete class).
    /// </summary>
    internal class DESWriter : FileWriter
    {
        // the encryption key
        private const string key = "12345678";

        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptExample.DESWriter"/> class.
        /// </summary>
        /// <param name="path">The path of the file to append.</param>
        public DESWriter(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Decrypts the file.
        /// </summary>
        protected override void DecryptFile()
        {
            if (File.Exists(_path))
            {
                using (FileStream fs = File.Open(_path, FileMode.OpenOrCreate))
                {
                    DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                    DES.Key = Encoding.ASCII.GetBytes(key);
                    DES.IV = Encoding.ASCII.GetBytes(key);
                    ICryptoTransform desdecrypt = DES.CreateDecryptor();
                    CryptoStream cryptostreamDecr = new CryptoStream(fs, desdecrypt, CryptoStreamMode.Read);
                    StreamWriter fsDecrypted = new StreamWriter("temp.txt");
                    fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
                    fsDecrypted.Flush();
                    fsDecrypted.Close();
                }
            }
        }

        /// <summary>
        /// Appends data to the file.
        /// </summary>
        /// <param name="data">The data to append.</param>
        protected override void AppendFile(string data)
        {
            using (FileStream fs = File.Open("temp.txt", FileMode.Append))
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
        protected override void EncryptFile()
        {
            using (FileStream fs = File.Open("temp.txt", FileMode.Open))
            {
                FileStream fsEncrypted = new FileStream(_path, FileMode.Create, FileAccess.Write);
                DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
                DES.Key = ASCIIEncoding.ASCII.GetBytes(key);
                DES.IV = ASCIIEncoding.ASCII.GetBytes(key);
                ICryptoTransform desencrypt = DES.CreateEncryptor();
                CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
                byte[] bytearrayinput = new byte[fs.Length];
                fs.Read(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                cryptostream.Close();
                fs.Close();
                fsEncrypted.Close();
            }
            File.Delete("temp.txt");
        }
    }
}