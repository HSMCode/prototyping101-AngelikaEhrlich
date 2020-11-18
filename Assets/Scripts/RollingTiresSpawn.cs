using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingTiresSpawn : MonoBehaviour
{
    //private float rotateSpeed = 1;
    //private float x = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 3);
        //transform.Rotate(new Vector3(x, 0, 0) * rotateSpeed);
    }
}
