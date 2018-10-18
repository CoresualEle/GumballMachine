using System;

namespace GumballMachine.Lib.States
{
    public class HasCoinState : IGumballMachineState
    {
        private static HasCoinState _instance;

        private HasCoinState()
        {
            Console.WriteLine($"{nameof(HasCoinState)} instantiated.");
        }

        public IGumballMachineState InsertCoin()
        {
            Console.WriteLine("Coin already inserted.");
            return GetInstance();
        }

        public IGumballMachineState EjectCoin()
        {
            Console.WriteLine("Coin ejected.");
            return NoCoinState.GetInstance();
        }

        public IGumballMachineState TurnLever()
        {
            Console.WriteLine("Purchase successful.");
            return NoCoinState.GetInstance();
        }

        public static IGumballMachineState GetInstance()
        {
            return _instance ?? (_instance = new HasCoinState());
        }
    }
}