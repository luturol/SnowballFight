using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Import this to use Scenes objects

public class Menu : MonoBehaviour
{
    public string mainGameScene;

    public void StartGame()
    {
        SceneManager.LoadScene(mainGameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
