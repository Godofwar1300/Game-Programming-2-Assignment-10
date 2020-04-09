/*
* (Christopher Green)
* (FallForce.cs)
* (Assignment 10)
* (This script adds force to the falling rain.)
*/
using UnityEngine;
using UnityEngine.UI;

public class FallForce : MonoBehaviour
{
    //private Rigidbody rb2d;
    //private float speed;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb2d = this.GetComponent<Rigidbody>();
    //    speed = 10f;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    rb2d.AddForce(Vector3.down * speed);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            PlayerStats.CheckPlayerHealth();

            Debug.Log("The Player has been hit!");
            PlayerStats.playerHealth -= 5f;

        }
    }
}
