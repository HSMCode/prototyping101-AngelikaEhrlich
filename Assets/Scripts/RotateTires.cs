using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTires : MonoBehaviour
{
    private float rotationSpeed = 4;

    // private GameObject wheels;
    private float x = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("up"))
        {
        // If TRUE, e.g. if up  arrow key is pressed, do:
        // Make the tires rotate
            transform.Rotate(new Vector3(x, 0, 0) * rotationSpeed);
        }

        if (Input.GetKey("down"))
        {
            // If TRUE, e.g. if down arrow key is pressed, do:
            // Make the tires rotate
            transform.Rotate(new Vector3(x, 0, 0) * rotationSpeed);
        }
    }
}
