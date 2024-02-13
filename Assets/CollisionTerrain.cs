using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTerrain : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BoundaryLeft"))
        {
            float newPositionX = transform.position.x;
            transform.position = new Vector3(newPositionX + 0.5f, transform.position.y,transform.position.z);
        }
        else if (collision.gameObject.CompareTag("BoundaryRight"))
        {
            float newPositionX = transform.position.x;
            transform.position = new Vector3(newPositionX - 0.5f, transform.position.y, transform.position.z);
        }
        else if (collision.gameObject.CompareTag("BoundaryStart"))
        {
            float newPositionZ = transform.position.z;
            transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ + 0.5f);
        }
        else if (collision.gameObject.CompareTag("BoundaryEnd"))
        {
            float newPositionZ = transform.position.z;
            transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ - 0.5f);
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
