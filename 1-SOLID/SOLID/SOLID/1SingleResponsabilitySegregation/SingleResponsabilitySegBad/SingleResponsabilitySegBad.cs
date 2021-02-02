using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;


namespace SOLID.SingleResponsabilitySegBad
{
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
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today twice.");
            j.AddEntry("I ate a bug.");
            WriteLine(j);

            var filename = @"c:\Temp\journal.txt";
            j.Save(filename);
            Process.Start(@"cmd.exe",filename);
        }
    }
}
