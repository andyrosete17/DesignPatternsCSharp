using System;
using System.Collections.Generic;

namespace DocumentEditorExample
{
	/// <summary>
	/// The document history class (the caretaker).
	/// </summary>
	public class DocumentHistory
	{
		// the list of current and prior document states
		private List<object> _history = new List<object> ();

		// a reference to the current document
		private Document _document = null;

		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentEditorExample.DocumentHistory"/> class.
		/// </summary>
		/// <param name="document">The document instance to use.</param>
		public DocumentHistory(Document document)
		{
			_document = document; 
		}

		/// <summary>
		/// Create a snapshot of the document and store it in the history list.
		/// </summary>
		public void Snapshot()
		{
			var memento = _document.SaveState ();
			_history.Add (memento);
		}

		/// <summary>
		/// Restore the document to the specified history record.
		/// </summary>
		/// <param name="index">The index number of the history record to use.</param>
		public void Restore(int index)
		{
			var memento = _history [index];
			_document.LoadState (memento);
		}
	}
}
