using GumballMachine.Lib.States;

namespace GumballMachine.Lib
{
    public class StatefulGumballMachine
    {
        private IGumballMachineState _state = NoCoinState.GetInstance();

        public StatefulGumballMachine()
        {
        }

        public void InsertCoin()
        {
            _state = _state.InsertCoin();
        }

        public void EjectCoin()
        {
            _state = _state.EjectCoin();
        }

        public void TurnLever()
        {
            _state = _state.TurnLever();
        }
    }
}