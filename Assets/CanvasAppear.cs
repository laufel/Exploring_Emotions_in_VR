using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasAppear : MonoBehaviour
{
    public Transform xrRig;
    public float detectRadius = 3.0f;
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