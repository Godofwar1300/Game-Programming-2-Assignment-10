/*
* (Christopher Green)
* (PlayerStats.cs)
* (Assignment 10)
* (This script handles tracking the player's health and the win state of the game.)
*/
using UnityEngine;

public static class PlayerStats
{

    public static float playerHealth = 100;
    public static bool gameOver = false;

    public static void CheckPlayerHealth()
    {
        if(playerHealth <= 0)
        {
            gameOver = true;
            Debug.Log("The player has died and the game is over.");
        }
        else
        {
            Debug.Log("The player is still alive with " + playerHealth.ToString("0") + "% of their health.");
        }
    }


}
