namespace LSJ
{
    public class GameLobbyState : GameState
    {
        public StateMachine _gameStateMachine = null;

        public GameLobbyState(StateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            StateID = (int)SCENE_STATE.LOBBY;
        }
    }
}