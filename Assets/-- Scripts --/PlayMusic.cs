using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayMusic : MonoBehaviour

{
    public Transform xrRig;    
    private float detectRadius = 6.0f;
    public TextMeshProUGUI msgText;
    float distanceToBench;

    private void Start()
    {
        msgText.gameObject.SetActive(false);
    }
    void Update()
    {
        distanceToBench = Vector3.Distance(xrRig.position, transform.position);
        if (distanceToBench <= detectRadius)
        {
            msgText.gameObject.SetActive(true);
        }
        else
        {
            msgText.gameObject.SetActive(false);
        }
    }



}