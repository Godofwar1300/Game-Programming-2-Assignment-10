/*
* (Christopher Green)
* (BlockRain.cs)
* (Assignment 10)
* (This script handles the functionality of the houses in blocking the rain from hitting the player.)
*/
using UnityEngine;

public class BlockRain : MonoBehaviour
{

    public int totalRainsBlocked;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Rain"))
        {
            totalRainsBlocked++;
            Debug.Log("Total amount of rain stopped:" + totalRainsBlocked);
            Destroy(other);
        }
    }


}
