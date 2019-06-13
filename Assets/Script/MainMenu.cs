using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame(string sceneName)
    {
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        Application.LoadLevel(sceneName);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
