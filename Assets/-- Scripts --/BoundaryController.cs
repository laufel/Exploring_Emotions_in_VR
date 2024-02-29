using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    public GameObject player;
    private bool isPlayerInBoundary = true;


    // Start is called before the first frame update
    void Start()
    {
        isPlayerInBoundary = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlayerInBoundary)
        {
            Vector3 newPosition = transform.position;
            player.transform.position = newPosition;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.ToString());
        if (other.gameObject == player) { 
            isPlayerInBoundary = false;
            Debug.Log(isPlayerInBoundary);
       
        }
    }
}
