using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlane : MonoBehaviour
{

    public float movementSpeed = 0.1f;
    private Vector3 startPos = new Vector3(65f, -0.8f, -3f);

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        material = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * movementSpeed * Time.deltaTime);

        //material.color.a = Random.Range(0.25f, 0.75f);

        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.position = startPos;
        }
    }

    void OnTriggerEnter(Collider other)
    {
;        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("dead");
            transform.position = startPos;
            // DEATHSCREEN + RESPAWN + Current Time METHODE
        }
        
    }
}
