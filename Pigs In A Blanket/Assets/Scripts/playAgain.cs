using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {

	// Reset Game Stats and Cleans the Game Map
	public void resetGame()
    {
        GameStats.playerCount = 0;
        SceneManager.LoadScene(0);
    }
}
