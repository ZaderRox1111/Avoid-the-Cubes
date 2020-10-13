using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float playerSpeed;

    void FixedUpdate()
    {
        //Movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(playerSpeed * Time.deltaTime, 0, 0);
        } if (Input.GetKey("a"))
        {
            rb.AddForce(-playerSpeed * Time.deltaTime, 0, 0);
        } if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, playerSpeed * Time.deltaTime);
        } if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -playerSpeed * Time.deltaTime);
        }
    }
}
