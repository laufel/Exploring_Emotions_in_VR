using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;

public class Stairs : MonoBehaviour
{
    private bool stairsClimbedOutside = false;
    int numStairsOut = 0;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("OutsideStairs"))
        {
            numStairsOut++;
            if (!stairsClimbedOutside)
            {
                float newPositionY = transform.position.y;
                transform.position = new Vector3(transform.position.x, newPositionY + 0.4f, transform.position.z);
                if (numStairsOut >= 3)
                {
                    stairsClimbedOutside = true;
                    numStairsOut = 0;
                }
                
            }
            else
            {
                float newPositionY = transform.position.y;
                transform.position = new Vector3(transform.position.x, newPositionY - 0.4f, transform.position.z);
                if (numStairsOut >= 3)
                {
                    stairsClimbedOutside = false;
                    numStairsOut = 0;
                }
            }


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




