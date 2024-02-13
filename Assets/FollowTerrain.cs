using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTerrain : MonoBehaviour
{

    private Transform playerTransform;
    public float heightOffset = 0.01f;
    public float rotationSpeed = 0.1f;
    private bool isMoving = false;

    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        lastPosition = transform.position;
    }

    // Update is called once per frame

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        float movementMagnitude = (currentPosition - lastPosition).magnitude;
        if (movementMagnitude > 0.01f) {
            isMoving = true;
        }

        else 
        {
            isMoving = false;
        }

        lastPosition = currentPosition;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit) && isMoving)
        {


            Vector3 newPosition = hit.point + Vector3.up * heightOffset;
            playerTransform.position = newPosition;

            Quaternion newRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
 
            playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, newRotation, Time.deltaTime * rotationSpeed);

                
        }


    }

}
