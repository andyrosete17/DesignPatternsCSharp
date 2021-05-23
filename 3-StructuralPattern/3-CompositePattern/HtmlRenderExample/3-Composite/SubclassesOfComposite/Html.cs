namespace HtmlRenderExample_3_Composite_SubclassesOfComposite
{
    using HtmlRenderExample_3_Composite;

    /// <summary>
    /// The concrete Html class.
    /// </summary>
    public class Html : HtmlTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRenderExample.Html"/> class.
        /// </summary>
        public Html()
            : base("html")
        {
        }
    }
}