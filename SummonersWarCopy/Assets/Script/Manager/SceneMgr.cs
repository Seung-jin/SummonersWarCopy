using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LSJ
{
    public class SceneMgr
    {
        public void ChangeScene(SCENE_STATE sceneState)
        {
            SceneManager.LoadSceneAsync((int)sceneState);
        }
    }

    public enum SCENE_STATE
    {
        LOBBY,
        STAGE,
    }
}