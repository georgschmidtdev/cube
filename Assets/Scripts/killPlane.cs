using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlane : MonoBehaviour
{

    public float movementSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * movementSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
;        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("dead");
            // DEATHSCREEN + RESPAWN + Current Time METHODE
        }
    }
}
