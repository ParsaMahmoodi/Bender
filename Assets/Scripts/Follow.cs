using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private GameObject Car;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Car = GameObject.Find("HillClimber");
        offset = Car.transform.position.x - this.transform.position.x;
        if (offset != 0)
        {
            this.transform.Translate(offset, 0f, 0f);
        }
    }
}
