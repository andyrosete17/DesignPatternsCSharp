using System;

namespace DocumentEditorExample
{
	/// <summary>
	/// The main program class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Writes the specified document to the console.
		/// </summary>
		/// <param name="text">The intro text to write.</param>
		/// <param name="document">The document to write.</param>
		private static void WriteDocument(string text, Document document)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine (text);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine (document);
		}

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			// instantiate a new document with history
			var document = new Document ();
			var history = new DocumentHistory (document);

			// change the document and make a snapshot before each change
			history.Snapshot ();
			document.Append ("The quick brown fox jumped over the lazy dog");
			history.Snapshot ();
			document.Italic ();
			history.Snapshot ();
			document.Bold ();
			WriteDocument ("Initial document:", document);

			// restore to unformatted text
			history.Restore (1);
			WriteDocument ("Document restored to record #1:", document);

			// restore to italic text
			history.Restore (2);
			WriteDocument ("Document restored to record #2:", document);

		}
	}
}
