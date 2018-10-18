using System;
using GumballMachine.Lib;

namespace GumballMachine.Cli
{
    internal class Program
    {
        private static readonly StatefulGumballMachine StatefulGumballMachine = new StatefulGumballMachine();

        private static void Main(string[] args)
        {
            while (QueryAction())
            {
                Console.WriteLine("...\n");
            }
        }

        private static bool QueryAction()
        {
            Console.Write("0: Exit\n1: Insert Coin\n2: Eject Coin\n3: Turn Lever\n");
            var action = Console.ReadKey();
            Console.WriteLine("");
            switch (action.KeyChar)
            {
                case '0':
                    return false;
                case '1':
                    StatefulGumballMachine.InsertCoin();
                    break;
                case '2':
                    StatefulGumballMachine.EjectCoin();
                    break;
                case '3':
                    StatefulGumballMachine.TurnLever();
                    break;
                default:
                    Console.WriteLine("Invalid Key; Retry");
                    break;
            }

            return true;
        }
    }
}