using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Text timerLabel;
    private float time;
    private float timeRemaining;
    private float allowedTime = 5;
    private int allowedMinutes = 0 / 60;

    public Text numPlayers;

    public void Start()
    {
        //Instantiate appropriate number of players
        if (GameStats.playerCount == 1)
        {

        }
        else if (GameStats.playerCount == 2)
        {
            
        }
        else if (GameStats.playerCount == 3)
        {

        }
        else if (GameStats.playerCount == 4)
        {

        }
        else
        {

        }
    }

    public void Update()
    {
        startTimer();
    }

    void startTimer()
    {

        time += Time.deltaTime;
        allowedTime -= Time.deltaTime;
        var minutesRemaining = allowedMinutes - (allowedMinutes - (allowedTime / 60));
        var secondsRemaining = allowedTime % 60;

        //update the label value
        if (secondsRemaining > 10)
        {
            timerLabel.text = string.Format("Time: {0,1:F0} : {1,2:F2}", Math.Ceiling(minutesRemaining) - 1, secondsRemaining);
        }
        else
        {
            timerLabel.text = string.Format("Time: {0,1:F0} : 0{1,2:F2}", Math.Ceiling(minutesRemaining) - 1, secondsRemaining);
        }

        //Check for end of game
        if (secondsRemaining <= 0 && minutesRemaining <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void spawnTruffles()
    {

    }

    void spawnPowerUps()
    {

    }

}
