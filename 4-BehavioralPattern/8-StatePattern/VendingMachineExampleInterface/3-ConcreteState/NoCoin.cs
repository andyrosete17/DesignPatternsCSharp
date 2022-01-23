namespace VendingMachineExampleInterface_3_ConcreteState
{
    using System;
    using VendingMachineExampleInterface_1_Context;
    using VendingMachineExampleInterface_2_State;

    /// <summary>
    /// The no-coin state class.
    /// </summary>
    public class NoCoin : IState
    {
        /// <summary>
        /// Handle inserting a coin into the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void InsertCoin(VendingMachine context)
        {
            if (context.Products > 0)
            {
                context.State = new CoinInserted();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Coin accepted");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sold out");
            }
        }

        /// <summary>
        /// Handle ejecting a coin from the vending machine.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void EjectCoin(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cannot eject coin because no coin was inserted");
        }

        /// <summary>
        /// Handle pushing the button.
        /// </summary>
        /// <param name="context">The context to use.</param>
        public void PushButton(VendingMachine context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pushing the button does nothing because no coin was inserted");
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