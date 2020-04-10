/*
* (Christopher Green)
* (HealthPickUp.cs)
* (Assignment 10)
* (This script handles the functionality of the health pickup when the player collects it.)
*/
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{

    public int healthRestoreNum;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            PlayerStats.playerHealth += healthRestoreNum;

            if(PlayerStats.playerHealth >= 100)
            {
                PlayerStats.playerHealth = 100;
            }

            Destroy(gameObject);

        }
    }
}