namespace SOLID._1__Single_Responsability_Segregation.SingleResponsabilitySegGood
{
    using System.IO;
    using SOLID.SingleResponsabilitySegGood;

    // handles the responsibility of persisting objects
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}