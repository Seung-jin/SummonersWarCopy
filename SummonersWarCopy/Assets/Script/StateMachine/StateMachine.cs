using System.Collections.Generic;

namespace LSJ
{
    public class StateMachine
    {
        public int CurrentState { get; private set; } = GameValue.InitInt;
        public int BeforeState { get; private set; } = GameValue.InitInt;

        private Dictionary<int, GameState> _gameStateMap = new Dictionary<int, GameState>();
        public void AddGameState(int stateID, GameState state)
        {
            if (_gameStateMap.ContainsKey(stateID) == false)
                _gameStateMap.Add(stateID, state);
        }

        public void ChangeState(int stateID)
        {
            BeforeState = CurrentState;
            if (CurrentState != GameValue.InitInt)
                _gameStateMap[CurrentState].End();

            CurrentState = stateID;
            _gameStateMap[CurrentState].Begin();
        }

        public void Update()
        {
            _gameStateMap[CurrentState].Update();
        }
    }
}