namespace GumballMachine.Lib.States
{
    public interface IGumballMachineState
    {
        IGumballMachineState InsertCoin();
        IGumballMachineState EjectCoin();
        IGumballMachineState TurnLever();
    }
}