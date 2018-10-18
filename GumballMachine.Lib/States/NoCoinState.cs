using System;

namespace GumballMachine.Lib.States
{
    public class NoCoinState : IGumballMachineState
    {
        private static NoCoinState _instance;

        private NoCoinState()
        {
            Console.WriteLine($"{nameof(NoCoinState)} instantiated.");
        }

        public IGumballMachineState InsertCoin()
        {
            Console.WriteLine("Coin inserted.");
            return HasCoinState.GetInstance();
        }

        public IGumballMachineState EjectCoin()
        {
            Console.WriteLine("No coin inserted.");
            return GetInstance();
        }

        public IGumballMachineState TurnLever()
        {
            Console.WriteLine("Insert coin first.");
            return GetInstance();
        }

        public static IGumballMachineState GetInstance()
        {
            return _instance ?? (_instance = new NoCoinState());
        }
    }
}