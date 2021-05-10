namespace BridgePattern._4_ConcreteImplementor
{
    using System;
    using BridgePattern._3_Implementor;

    /// <summary>
    /// The concrete implementor B class.
    /// </summary>
    public class ConcreteImplementorB : Implementor
    {
        /// <summary>
        /// Perform a low-level implementation operation.
        /// </summary>
        public override void OperationImp()
        {
            throw new NotImplementedException("OperationImp is not implemented");
        }
    }
}