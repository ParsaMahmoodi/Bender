using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 20;
    [SerializeField] float speedDecrease = -0.7f;

    void Start()
    {
        
    }

    
    void Update()
    {
        float playerSpeed = speed * Time.deltaTime;

        if(Input.GetAxis("Horizontal") == 1)
        {
            transform.Translate(playerSpeed, 0f, 0f);
        }
        else if(Input.GetAxis("Horizontal") == -1)
        {
            transform.Translate(speedDecrease * playerSpeed, 0f, 0f);
        }



    }
}
