using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;

public class SitOnBench : MonoBehaviour
{
    public Transform xrRig; // Assicurati di assegnare il tuo XR Rig a questa variabile nella finestra Inspector. 
    public Transform sittingPosition; // Posizione dove il personaggio si siederà (la panchina). 
    public InputActionProperty InputActionProperty;
    private float detectRadius = 4.0f;
    //public UnityEvent ActionPerformed;
    private bool isSitting = false;
    public TextMeshProUGUI msgText;
    float distanceToBench;
    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
    }


    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        distanceToBench = Vector3.Distance(xrRig.position, sittingPosition.position);
        if (isSitting) { 
            isSitting = false;
            xrRig.position += new Vector3(-1, 2, 0);
        }
        else { 
            if (distanceToBench <= detectRadius)
            {
                isSitting = true;
                msgText.gameObject.SetActive(false);
            }
        }

    }
    void Update()

    {
        distanceToBench = Vector3.Distance(xrRig.position, sittingPosition.position);
        if (isSitting)
        {
            xrRig.position = sittingPosition.position;
            xrRig.rotation = sittingPosition.rotation;
        }
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

