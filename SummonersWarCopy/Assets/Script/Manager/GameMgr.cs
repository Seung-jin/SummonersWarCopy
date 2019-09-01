using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSJ
{
    public class GameMgr : MonoBehaviour
    {
        private StateMachine _gameStateMachine = null;

        private void Init()
        {
            MakeGameStateMachine();
        }

        private void MakeGameStateMachine()
        {
            _gameStateMachine = new StateMachine();
            _gameStateMachine.AddGameState((int)SCENE_STATE.LOBBY, new GameLobbyState(_gameStateMachine));
            _gameStateMachine.AddGameState((int)SCENE_STATE.STAGE, new GameLobbyState(_gameStateMachine));

            _gameStateMachine.ChangeState((int)SCENE_STATE.LOBBY);
        }
    }

    public enum SCENE_STATE
    {
        LOBBY,
        STAGE,
    }
}