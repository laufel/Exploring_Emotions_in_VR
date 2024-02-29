using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System.IO;


public class Follower : MonoBehaviour
{
    public InputActionProperty InputActionProperty;

    public UnityEvent ActionPerformed;

    public PathCreator pathCreator;
    public float speed = 1.0f;
    float distanceTravelled;

    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
    }
    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        MoveAlongPath();
    }

    // Update is called once per frame
    private void MoveAlongPath()
    {
        if (InputActionProperty.action.ReadValue<Vector2>().y  > 0) 
        { distanceTravelled -= speed * Time.deltaTime;
        }
        else if (InputActionProperty.action.ReadValue<Vector2>().y < 0) { distanceTravelled += speed * Time.deltaTime; }

        distanceTravelled = Mathf.Clamp(distanceTravelled, -pathCreator.path.length, pathCreator.path.length);

        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        //transform.rotation = pathCreator.path.GetRotationAtDistance (distanceTravelled);
    }
}
