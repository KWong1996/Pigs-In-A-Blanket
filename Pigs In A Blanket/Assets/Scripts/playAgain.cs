using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour {

	// Reset Game Stats and Cleans the Game Map
	public void resetGame()
    {
        GameStats.playerCount = 0;
        GameStats.player1Score = 0;
        GameStats.player2Score = 0;
        GameStats.player3Score = 0;
        GameStats.player4Score = 0;
        SceneManager.LoadScene(0);
    }
}
