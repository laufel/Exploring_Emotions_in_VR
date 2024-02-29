using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float turnSpeed = 30.0f;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Space.World);
        transform.Translate(0f, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, Space.Self);


    }
}
