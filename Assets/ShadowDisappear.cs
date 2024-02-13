using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ShadowDisappear : MonoBehaviour
{
    public Transform xrRig;
    public float detectRadius = 5.0f;
    float distance;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(xrRig.position, transform.position);
        if (distance < detectRadius)
        {
            this.gameObject.SetActive(false);
        }
       
    }
}
