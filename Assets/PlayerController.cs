using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 lastValidPosition;

    // Start is called before the first frame update
    void Start()
    {
        lastValidPosition = transform.position;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boundary")){
            transform.position = lastValidPosition;
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position != lastValidPosition)
        {
            lastValidPosition = transform.position;
        }



    }
}