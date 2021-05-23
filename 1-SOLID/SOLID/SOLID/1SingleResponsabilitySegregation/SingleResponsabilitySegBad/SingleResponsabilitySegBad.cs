namespace SOLID.SingleResponsabilitySegBad
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using static System.Console;

    // just stores a couple of journal entries and ways of
    // working with them
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // memento pattern!
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // breaks single responsibility principle beacuse we are adding too much responsability to the journal class
        // Journal is not only responsible for keeping the entries, but also for the persistence of the data
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }

        public void Load(string filename)
        {
        }

        public void Load(Uri uri)
        {
        }
    }

    public class Demo
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today twice.");
            journal.AddEntry("I ate a bug.");
            WriteLine(journal);

            var filename = @"c:\Temp\journal.txt";
            journal.Save(filename);
            Process.Start(@"cmd.exe", filename);
        }
    }
}