using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeSceneChange : MonoBehaviour
{
    public void SceneChange(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
