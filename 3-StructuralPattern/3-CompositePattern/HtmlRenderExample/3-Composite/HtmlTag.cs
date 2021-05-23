namespace HtmlRenderExample_3_Composite
{
    using System.Collections.Generic;
    using System.Text;
    using HtmlRenderExample._1_Component;

    /// <summary>
    /// The composite abstract base class.
    /// </summary>
    public abstract class HtmlTag : HtmlNode
    {
        // the name of the HTML tag
        protected string _tagName = null;

        // the list of child components
        protected List<HtmlNode> _elements = new List<HtmlNode>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRenderExample.HtmlTag"/> class.
        /// </summary>
        /// <param name="tagName">Tag name.</param>
        protected HtmlTag(string tagName)
        {
            _tagName = tagName;
        }

        /// <summary>
        /// Adds a child component.
        /// </summary>
        /// <param name="component">The child component to add.</param>
        public void AddChild(HtmlNode component)
        {
            _elements.Add(component);
        }

        /// <summary>
        /// Perform an operation on the component.
        /// </summary>
        public override string Render()
        {
            // start with an opening tag
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<{0}>", _tagName);

            // add child content
            foreach (HtmlNode child in _elements)
            {
                sb.Append(child.Render());
            }

            // end with a closing tag
            sb.AppendFormat("</{0}>", _tagName);

            // return results
            return sb.ToString();
        }
    }
}