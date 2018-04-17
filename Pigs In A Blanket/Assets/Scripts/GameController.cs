﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public Text timerLabel;
    private float time;
    private float timeRemaining;
    private float allowedTime = 240;
    private int allowedMinutes = 240 / 60;

    public Text numPlayers;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;

	public Sprite openChest = Resources.Load<Sprite>("chestsOpen");
	public Sprite closedChest = Resources.Load<Sprite>("chestsClosed");
	public Sprite truffle = Resources.Load<Sprite>("truffle");
    public void Start()
    {
        //Instantiate appropriate number of players
        if (GameStats.playerCount == 1)
        {

            P1.SetActive(true);
            P2.SetActive(false);
            P3.SetActive(false);
            P4.SetActive(false);

        }
        else if (GameStats.playerCount == 2)
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(false);
            P4.SetActive(false);
        }
        else if (GameStats.playerCount == 3)
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(true);
            P4.SetActive(false);
        }
        else if (GameStats.playerCount == 4)
        {
            P1.SetActive(true);
            P2.SetActive(true);
            P3.SetActive(true);
            P4.SetActive(true);
        }
        else
        {

        }
    }

    public void Update()
    {
        int secondsRemaining = startTimer();
		openChests(secondsRemaining);
    }

    int startTimer()
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
		return (int)allowedTime;

    }

	void openChests(int timePass)
	{
		GameObject[] chests;
		if (timePass%15 == 0) {
			chests = GameObject.FindGameObjectsWithTag("Chest");
			foreach (GameObject chest in chests)
			{
				SpriteRenderer spriteR = chest.GetComponent<SpriteRenderer>();
				spriteR.sprite = Resources.LoadAll<Sprite>("chests")[1];
			}
		}
	}

    void spawnTruffles()
    {

    }

    void spawnPowerUps()
    {

    }
}
