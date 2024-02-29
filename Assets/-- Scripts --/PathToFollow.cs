using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System.IO;


public class PathToFollow : MonoBehaviour

{
    public InputActionProperty InputActionProperty;
    public UnityEvent ActionPerformed;

    public PathCreator pathCreator;
    public float velocità = 5.0f;
    public float margineX = 1.0f; // Margine rispetto all'asse X 

    private float distanceTravelled;
    private bool muovimentoDestra = true; // Direzione iniziale 



 

    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
    }
    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        MoveAlongPath();
    }

    private void MoveAlongPath()
    {
        if (InputActionProperty.action.ReadValue<Vector2>().y > 0)
        {
            distanceTravelled -= velocità * Time.deltaTime;
            Vector3 posizioneSulPercorso = pathCreator.path.GetPointAtDistance(distanceTravelled);


        // Aggiungi il margine rispetto all'asse X 

            Vector3 position = new Vector3(posizioneSulPercorso.x + (muovimentoDestra ? margineX : -margineX), posizioneSulPercorso.y, posizioneSulPercorso.z);



        // Imposta la posizione del personaggio sulla strada con il margine 

            transform.position = position;

            if (posizioneSulPercorso.x > margineX || posizioneSulPercorso.x < -margineX)

            {

                muovimentoDestra = !muovimentoDestra;

            }
        }
        else if (InputActionProperty.action.ReadValue<Vector2>().y < 0) 
        { 
            distanceTravelled += velocità * Time.deltaTime; 
        }

    }

}
