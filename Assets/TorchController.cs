using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class TorchController : MonoBehaviour
{
    public Transform subject; 

    public PathCreator pathCreator;

    public float checkInterval = 1.0f; 

    private float pathWidth;



    private void Start()

    {
        pathWidth = pathCreator.path.bounds.size.x;
        InvokeRepeating("CheckTorchPosition", 0.0f, checkInterval);
    }



    private void CheckTorchPosition()

    {
        float torchX = transform.position.x;
        float pathX = pathCreator.path.GetClosestPointOnPath(subject.position).x;
        Debug.Log(subject.position);

        if (Mathf.Abs(torchX - pathX) > pathWidth / 2)

        {

            transform.position = new Vector3(pathX, transform.position.y, transform.position.z);

        }

    }
}
