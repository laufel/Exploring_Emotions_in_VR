using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject JumpScareGameObject;

    // Start is called before the first frame update
    void Start()
    {
        JumpScareGameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            JumpScareGameObject.SetActive(true);
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(JumpScareGameObject);
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
