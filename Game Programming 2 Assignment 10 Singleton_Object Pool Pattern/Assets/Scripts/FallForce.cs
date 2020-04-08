/*
* (Christopher Green)
* (FallForce.cs)
* (Assignment 10)
* (This script adds force to the falling rain.)
*/
using UnityEngine;

public class FallForce : MonoBehaviour
{
    private Rigidbody rb2d;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody>();
        speed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(Vector3.down * speed);
    }
}
