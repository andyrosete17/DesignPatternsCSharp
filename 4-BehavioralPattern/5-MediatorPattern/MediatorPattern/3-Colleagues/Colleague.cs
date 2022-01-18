namespace MediatorPattern_3_Colleague
{
    using MediatorPattern_1_Mediator;

    /// <summary>
    /// The abstract colleague class.
    /// </summary>
    public abstract class Colleague
    {
        // the reference to the mediator
        protected Mediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediatorPattern.Colleague"/> class.
        /// </summary>
        /// <param name="mediator">The mediator instance to use.</param>
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}