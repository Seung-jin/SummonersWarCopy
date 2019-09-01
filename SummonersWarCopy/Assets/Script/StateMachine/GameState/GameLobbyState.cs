namespace LSJ
{
    public class GameLobbyState : GameState
    {
        public GameLobbyState( )
        {
            StateID = (int)SCENE_STATE.LOBBY;
        }

        public override void Begin()
        {
            base.Begin();
            UnityEngine.Debug.Log("Lobby Begin");
        }
    }
}