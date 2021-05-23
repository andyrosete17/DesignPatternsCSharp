namespace HtmlRenderExample_3_Composite_SubclassesOfComposite
{
    using HtmlRenderExample_3_Composite;

    /// <summary>
    /// The concrete body class.
    /// </summary>
    public class Body : HtmlTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRenderExample.Body"/> class.
        /// </summary>
        public Body()
            : base("body")
        {
        }
    }
}