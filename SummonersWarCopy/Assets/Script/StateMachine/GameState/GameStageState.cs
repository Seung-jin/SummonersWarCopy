namespace LSJ
{
    public class GameStageState : GameState
    {
        public StateMachine _gameStateMachine = null;

        public GameStageState(StateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
            StateID = (int)SCENE_STATE.STAGE;
        }
    }
}