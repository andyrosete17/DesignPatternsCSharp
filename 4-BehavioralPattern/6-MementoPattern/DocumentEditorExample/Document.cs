namespace DocumentEditorExample
{
    /// <summary>
    /// The document class (the originator).
    /// </summary>
    public class Document
    {
        /// <summary>
        /// The document state class (the memento).
        /// *******As you can see the SaveState method return a new object as an object type, and the document states class is actually embedded inside 
        /// the document class and its private. This trick makes the memento completely unreadble to the outside world. By making the document states
        /// private and local to documents, we ensure that it can only be accessed from inside the document itself. 
        /// So safe methods must return the memento as untyped object, because the outside world cannot access the docuemnt states class declaration,
        /// s nobody excepts documents can cast the memento back to a document state instance. (Load State)*******
        /// </summary>
        private sealed class DocumentState
        {
            // the recorded state of the document
            private string _state;

            /// <summary>
            /// Initializes a new instance of the <see cref="Document+DocumentState"/> class. This would be the memento object
            /// </summary>
            /// <param name="state">The state to record.</param>
            public DocumentState(string state)
            {
                _state = state;
            }

            /// <summary>
            /// Gets the document state. to read the state information
            /// </summary>
            /// <value>The document state.</value>
            public string State
            {
                get { return _state; }
            }
        }

        // the private state of the document
        private string _html;

        /// <summary>
        /// Append the specified text to the document.
        /// </summary>
        /// <param name="text">The text to append.</param>
        public void Append(string text)
        {
            _html += text;
        }

        /// <summary>
        /// Format all document text as italic.
        /// </summary>
        public void Italic()
        {
            _html = "<i>" + _html + "</i>";
        }

        /// <summary>
        /// Format all document text as bold.
        /// </summary>
        public void Bold()
        {
            _html = "<b>" + _html + "</b>";
        }

        /// <summary>
        /// Save the document state and return it in a new memento.
        /// </summary>
        /// <returns>A memento holding the current state.</returns>
        public object SaveState()
        {
            return (new DocumentState(_html));
        }

        /// <summary>
        /// Load the state from specified memento into the document..
        /// </summary>
        /// <param name="docstate">The memento holding the state to load.</param>
        public void LoadState(object docstate)
        {
            _html = (docstate as DocumentState).State;
        }

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current <see cref="Document"/>.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the current <see cref="Document"/>.</returns>
        public override string ToString()
        {
            return _html;
        }
    }
}