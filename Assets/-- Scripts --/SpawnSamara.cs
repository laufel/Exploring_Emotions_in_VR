using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SpawnSamara : MonoBehaviour
{

    public float spawnRadius1 = 20.0f;
    public float spawnRadius2 = 0.8f;
    public float spawnInterval = 3.0f; 
    public float moveSpeed = 3.0f; // Velocità di movimento della figura oscura 
    public GameObject  darkFigure; // Riferimento al trasform della figura oscura 
    private GameObject playerXR;
    private XRController XRcontroller;
    private float timer = 0.0f;


    void Start()
    {
        playerXR = GameObject.FindWithTag("Player");
        XRcontroller = playerXR.GetComponentInChildren<XRController>();

    }

    void Update()
    {

        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            float angle = Random.Range(0, 2 * Mathf.PI);
            float x = Mathf.Cos(angle) * spawnRadius1;
            float z = Mathf.Sin(angle) * spawnRadius2;
            Vector3 randomPosition = transform.position + new Vector3(x, 0, z);
            darkFigure.SetActive(true);
            darkFigure.transform.position = randomPosition;
            StartCoroutine(DisableScaryFigure());
            timer = 0.0f;
        }

    }

    IEnumerator DisableScaryFigure()
    {
        darkFigure.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        darkFigure.SetActive(true);
        
       
    }

    
}



