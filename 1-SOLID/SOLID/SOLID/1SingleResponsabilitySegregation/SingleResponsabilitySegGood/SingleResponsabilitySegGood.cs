namespace SOLID.SingleResponsabilitySegGood
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using SOLID._1__Single_Responsability_Segregation.SingleResponsabilitySegGood;
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
    }

    public class Demo
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today twice.");
            journal.AddEntry("I ate a bug.");
            WriteLine(journal);

            var persistence = new Persistence();
            var filename = @"c:\Temp\journal.txt";
            persistence.SaveToFile(journal, filename);
            Process.Start(@"cmd.exe", filename);
        }
    }
}