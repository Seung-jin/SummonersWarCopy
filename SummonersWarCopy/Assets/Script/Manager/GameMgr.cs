using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSJ
{
    public class GameMgr : MonoBehaviour
    {
        private StateMachine _gameStateMachine = null;
        private SceneMgr _sceneMgr = null;

        public static GameMgr Instance = null;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(gameObject);
            DontDestroyOnLoad(gameObject);

            Init();
        }

        private void Init()
        {
            MakeGameStateMachine();
            _sceneMgr = new SceneMgr();
        }

        private void MakeGameStateMachine()
        {
            _gameStateMachine = new StateMachine();
            _gameStateMachine.AddGameState((int)SCENE_STATE.LOBBY, new GameLobbyState());
            _gameStateMachine.AddGameState((int)SCENE_STATE.STAGE, new GameStageState());

            _gameStateMachine.ChangeState((int)SCENE_STATE.LOBBY);
        }

        public void ChangeScene(SCENE_STATE sceneState)
        {
            _sceneMgr.ChangeScene(sceneState);
            _gameStateMachine.ChangeState((int)sceneState);
        }
    }
}