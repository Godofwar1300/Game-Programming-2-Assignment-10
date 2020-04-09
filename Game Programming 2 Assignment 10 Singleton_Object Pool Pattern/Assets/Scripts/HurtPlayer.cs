/*
* (Christopher Green)
* (HurtPlayer.cs)
* (Assignment 10)
* (This script defines what id done when the player gets hurt.)
*/
using UnityEngine;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{

    public Text healthText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Rain"))
        {
            PlayerStats.CheckPlayerHealth();

            Debug.Log("The Player has been hit!");
            PlayerStats.playerHealth -= 5f;

            healthText.text = "Health:  " + PlayerStats.playerHealth.ToString("0") + "%";

        }
    }

}
