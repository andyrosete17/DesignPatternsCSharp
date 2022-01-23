namespace VendingMachineExampleInterface_3_ConcreteState
{
    using System;
    using VendingMachineExampleInterface_1_Context;
    using VendingMachineExampleInterface_2_State;

    /// <summary>
    /// The sold-out state class.
    /// </summary>
    public class SoldOut : IState
    {
        /// <summary>
        /// Handle inserting a coin into the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void InsertCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out");
        }

        /// <summary>
        /// Handle ejecting a coin from the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void EjectCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out");
        }

        /// <summary>
        /// Handle pushing the button.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void PushButton(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The machine is sold out");
        }

        /// <summary>
        /// Handle dispensing the chocolate.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void DispenseChocolate(VendingMachine context)
        {
            // silent because PushButton already alerts the user
        }
    }
}