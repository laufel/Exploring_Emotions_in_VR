using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsClimbing : MonoBehaviour
{
    private bool stairs = false; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stairs") && !stairs)
        {
            float newPosition = transform.position.y;
            transform.position = new Vector3(transform.position.x, newPosition + 2.5f, transform.position.z - 4.0f);
            stairs = true;
        } 
        
        else if (collision.gameObject.CompareTag("Stairs") && stairs)
        {
            float newPositionY = transform.position.y;
            transform.position = new Vector3(transform.position.x, newPositionY - 2.5f, transform.position.z + 4.0f);
            stairs = false;
        }

    }

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


