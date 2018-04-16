using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame(int numPlayers)
    {
        if (numPlayers == 1)
        {
            GameStats.playerCount = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (numPlayers == 2)
        {
            GameStats.playerCount = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (numPlayers == 3)
        {
            GameStats.playerCount = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (numPlayers == 4)
        {
            GameStats.playerCount = 4;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {

        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
