using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerForBike : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float forwardSpeed = 12f;

    [SerializeField] float torqueAmount = -1f;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            surfaceEffector2D.speed = forwardSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            surfaceEffector2D.speed = -0.7f * forwardSpeed;
        }
        else
            surfaceEffector2D.speed = 0;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
