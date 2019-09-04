using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Import this to use Scenes objects

public class Menu : MonoBehaviour
{
    public string level1;
    public string level2;    

    public void StartLevel1()
    {
        SceneManager.LoadScene(level1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(level2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
