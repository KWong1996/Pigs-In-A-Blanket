using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStats {

    private static int numPlayers;

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

}
