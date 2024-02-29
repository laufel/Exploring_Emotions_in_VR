using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class StairsElevator : MonoBehaviour
{
    public Transform xrRig;
    public InputActionProperty InputActionProperty;
    private float detectRadius = 6.0f;
    public TextMeshProUGUI msgTextUp;
    public TextMeshProUGUI msgTextDown;
    float distance;
    private bool stairsClimbed = false;
    private bool allowedDown = false;

    private void OnEnable()
    {
        InputActionProperty.action.performed += OnActionPerformed;
        
    }

    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        distance = Vector3.Distance(xrRig.position, transform.position);
        if ((!stairsClimbed) && (distance < detectRadius))
        {
            stairsClimbed = true;
            xrRig.position += new Vector3(2.5f, 4.8f, 0);
            msgTextUp.gameObject.SetActive(false);
            msgTextDown.gameObject.SetActive(true);
        }

        else if ((stairsClimbed) && (distance < detectRadius))
        {
            stairsClimbed = false;
            xrRig.position += new Vector3(-2.5f, -4.8f, 0);
            msgTextDown.gameObject.SetActive(false);
            msgTextUp.gameObject.SetActive(true);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        msgTextDown.gameObject.SetActive(false);
        msgTextUp.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(xrRig.position, transform.position);
        if (distance < detectRadius) {
            msgTextUp.gameObject.SetActive(true);
        }
        
    }
}
