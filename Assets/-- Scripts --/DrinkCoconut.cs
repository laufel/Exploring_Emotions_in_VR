using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;

public class DrinkCoconut : MonoBehaviour
{
    public Transform xrRig; // Assicurati di assegnare il tuo XR Rig a questa variabile nella finestra Inspector. 
    public InputActionProperty InputActionProperty;
    private float detectRadius = 4.0f;
    private bool hasDrunk = false;
    public TextMeshProUGUI msgText;
    float distanceToBench;

    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
    }


    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        distanceToBench = Vector3.Distance(xrRig.position, transform.position);
        if (hasDrunk)
        {
            hasDrunk = false;
        }
        else
        {
            if (distanceToBench <= detectRadius)
            {
                hasDrunk = true;
                msgText.gameObject.SetActive(false);
            }
        }

    }
    void Update()

    {
        distanceToBench = Vector3.Distance(xrRig.position, transform.position);
 
        if (distanceToBench <= detectRadius)
        {
            msgText.gameObject.SetActive(true);
        }
        else { msgText.gameObject.SetActive(false); }
    }
   
    private void Start()
    {
        msgText.gameObject.SetActive(false);
    }
}
