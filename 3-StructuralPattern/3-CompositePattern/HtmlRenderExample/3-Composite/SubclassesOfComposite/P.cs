namespace HtmlRenderExample_3_Composite_SubclassesOfComposite
{
    using HtmlRenderExample_3_Composite;

    /// <summary>
    /// The concrete p class.
    /// </summary>
    public class P : HtmlTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRenderExample.P"/> class.
        /// </summary>
        public P()
            : base("p")
        {
        }
    }
}