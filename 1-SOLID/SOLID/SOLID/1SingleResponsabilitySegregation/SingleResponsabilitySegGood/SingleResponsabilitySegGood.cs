using System;
using System.Collections.Generic;
using System.Diagnostics;
using SOLID._1__Single_Responsability_Segregation.SingleResponsabilitySegGood;
using static System.Console;

namespace SOLID.SingleResponsabilitySegGood
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
    }

    public class Demo
    {
        private static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today twice.");
            j.AddEntry("I ate a bug.");
            WriteLine(j);

            var p = new Persistence();
            var filename = @"c:\Temp\journal.txt";
            p.SaveToFile(j, filename);
            Process.Start(@"cmd.exe", filename);
        }
    }
}