using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour
{
    public float windStrengh = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody[] treeBranches = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody branch in treeBranches )
        {
            Vector3 windForce = Random.insideUnitSphere * windStrengh;
            branch.AddForce(windForce);
        }
    }
}
