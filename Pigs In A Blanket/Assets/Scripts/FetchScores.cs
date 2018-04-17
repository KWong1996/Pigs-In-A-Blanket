using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FetchScores : MonoBehaviour {

    public Text P1_Score;
    public Text P2_Score;
    public Text P3_Score;
    public Text P4_Score;

    void Update()
    {

        P1_Score.text = "Player 1: " + GameStats.player1Score;
        P2_Score.text = "Player 2: " + GameStats.player2Score;
        P3_Score.text = "Player 3: " + GameStats.player3Score;
        P4_Score.text = "Player 4: " + GameStats.player4Score;

    }
}
