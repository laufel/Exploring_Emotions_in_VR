using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoundarySet : MonoBehaviour
{
    public float xRange;
    public float zRange;
    public float xRange2;
    public float zRange2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x > xRange)
        {
            transform.position= new Vector3(xRange, transform.position.y,transform.position.z);
        }

        if (transform.position.x < -xRange2)
        {
            transform.position = new Vector3(-xRange2, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < -zRange2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange2);
        }
    }
    
}
