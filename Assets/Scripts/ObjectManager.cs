using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ground);
        GameObject HillClimber = Instantiate(Car);
        HillClimber.name = "HillClimber";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
