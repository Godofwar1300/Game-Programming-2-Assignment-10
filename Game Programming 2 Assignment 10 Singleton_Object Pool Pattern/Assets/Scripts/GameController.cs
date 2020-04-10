/*
* (Christopher Green)
* (GameController.cs)
* (Assignment 10)
* (This script defines basic functionality of the game such as timers and so on.)
*/

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text healthText;
    public Text yellowThingsText;

    private void Update()
    {
        healthText.text = "Health:  " + PlayerStats.playerHealth.ToString("0") + "%";
        yellowThingsText.text = "Total Yellow Things: " + PlayerStats.totalYellowThings + " / 5";

        PlayerStats.CheckPlayerHealth();

        if (PlayerStats.totalYellowThings >= 5)
        {
            PlayerStats.gameVictory = true;
        }

        if (PlayerStats.gameOver)
        {
            GameLost();
        }

        if(PlayerStats.gameVictory)
        {
            GameWin();
        }

    }

    public void GameWin()
    {
        SceneManager.LoadScene(3);
    }

    public void GameLost()
    {
        SceneManager.LoadScene(4);
    }
}
