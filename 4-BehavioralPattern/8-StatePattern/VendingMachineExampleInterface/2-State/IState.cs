namespace VendingMachineExampleInterface_2_State
{
    using VendingMachineExampleInterface_1_Context;

    /// <summary>
    /// The abstract state class.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Handle inserting a coin into the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        void InsertCoin(VendingMachine context);

        /// <summary>
        /// Handle ejecting a coin from the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        void EjectCoin(VendingMachine context);

        /// <summary>
        /// Handle pushing the button.
        /// </summary>
        /// <param name="context">The context to use.</param>
        void PushButton(VendingMachine context);

        /// <summary>
        /// Handle dispensing the chocolate.
        /// </summary>
        /// <param name="context">The context to use.</param>
        void DispenseChocolate(VendingMachine context);
    }
}