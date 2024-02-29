using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;




public class AutomaticStairClimbing : MonoBehaviour

{

    public float stairDetectionDistance = 1.0f;  
    public float stepHeight = 0.1f;  
    public LayerMask stairLayer;  // Layer che rappresenta le scale 



    private XRController leftController;  // Riferimento al controller sinistro 
    private XRController rightController;  // Riferimento al controller destro 
    private bool isClimbing = false;
    private int stepsClimbed = 0;
    private Vector3 initialPosition;



    private void Start()

    {

        leftController = GetComponent<XRController>(); // Sostituire con il tuo sistema di input 
        rightController = GetComponent<XRController>(); 
        initialPosition = transform.position;

    }



    private void Update()

    {
        if (!isClimbing)

        {

            // Lancio un raycast in avanti da ciascun controller per rilevare le scale 

            if (Physics.Raycast(leftController.transform.position, Vector3.up, out RaycastHit leftHit, stairDetectionDistance, stairLayer) ||

                Physics.Raycast(rightController.transform.position, Vector3.up, out RaycastHit rightHit, stairDetectionDistance, stairLayer))

            {

                StartClimbing();

            }

        }

        else

        {

            // Continuo a salire le scale 

            Vector3 moveDirection = Vector3.up *stepHeight;
            transform.Translate(moveDirection);
            stepsClimbed++;

            // Controlla se hai raggiunto la cima delle scale 

            if (stepsClimbed >=4)

            {

                StopClimbing();

            }

        }

    }



    private void StartClimbing()

    {

        isClimbing = true;

    }



    private void StopClimbing()

    {

        isClimbing = false;
        stepsClimbed = 0;
       


    }

}

