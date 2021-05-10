namespace BridgePattern._4_ConcreteImplementor
{
    using System;
    using BridgePattern._3_Implementor;

    /// <summary>
    /// The concrete implementor A class.
    /// </summary>
    public class ConcreteImplementorA : Implementor
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