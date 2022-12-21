using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    private float movement;
    private float carTorque=10f;
    private float speed=30f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
     void FixedUpdate()
    {
        backTire.AddTorque(-movement*speed*Time.fixedDeltaTime);
        frontTire.AddTorque(-movement*speed*Time.fixedDeltaTime);
        carRigidbody.AddTorque(-movement* carTorque * Time.fixedDeltaTime);
    }
}
