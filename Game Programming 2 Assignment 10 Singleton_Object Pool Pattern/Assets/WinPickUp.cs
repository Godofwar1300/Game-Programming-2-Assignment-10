/*
* (Christopher Green)
* (WinPickUp.cs)
* (Assignment 10)
* (This script handles the functionality of the yellow thing / win pickup when the player collects it.)
*/
using UnityEngine;

public class WinPickUp : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            PlayerStats.totalYellowThings += 1;

            Destroy(gameObject);
        }
    }
}
