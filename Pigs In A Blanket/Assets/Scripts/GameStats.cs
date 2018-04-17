using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStats {

    private static int numPlayers;

    private static int P1_Score = 0;
    private static int P2_Score = 0;
    private static int P3_Score = 0;
    private static int P4_Score = 0;

    public static int playerCount
    {
        get
        {
            return numPlayers;
        }
        set
        {
            numPlayers = value;
        }
    }

    public static int player1Score
    {
        get
        {
            return P1_Score;
        }
        set
        {
            P1_Score = value;
        }
    }

    public static int player2Score
    {
        get
        {
            return P2_Score;
        }
        set
        {
            P2_Score = value;
        }
    }

    public static int player3Score
    {
        get
        {
            return P3_Score;
        }
        set
        {
            P3_Score = value;
        }
    }

    public static int player4Score
    {
        get
        {
            return P4_Score;
        }
        set
        {
            P4_Score = value;
        }
    }

}
