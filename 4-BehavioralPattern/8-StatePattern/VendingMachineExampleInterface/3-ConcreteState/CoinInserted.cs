namespace VendingMachineExampleInterface_3_ConcreteState
{
    using System;
    using VendingMachineExampleInterface_1_Context;
    using VendingMachineExampleInterface_2_State;

    /// <summary>
    /// The coin-inserted state class.
    /// </summary>
    public class CoinInserted : IState
    {
        /// <summary>
        /// Handle inserting a coin into the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void InsertCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot insert a second coin");
        }

        /// <summary>
        /// Handle ejecting a coin from the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Coin returned");
        }

        /// <summary>
        /// Handle pushing the button.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void PushButton(VendingMachine context)
        {
            context.State = new Sold();
            // no console alert because the next state will do it
        }

        /// <summary>
        /// Handle dispensing the chocolate.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void DispenseChocolate(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You must press the button first");
        }
    }
}