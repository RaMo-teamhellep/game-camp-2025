using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{    
    public void LoadLevel(string level)
    {
        // level = "Level2"
        SceneManager.LoadScene(level);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RequestWin()
    {
        Invoke(nameof(TransitionToWin), 4f);
    }

    private void TransitionToWin()
    {
        LoadLevel("End");
    }
}
