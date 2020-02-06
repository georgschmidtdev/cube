using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalLogic : MonoBehaviour

{

    public GameObject otherPortal;
    //public Rigidbody playerRB;
    //private Transform PlayerTransform;
    //private Transform GoalTransform;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerTransform = GameObject.Find("Player").transform;

        Debug.Log(otherPortal.name);
        //playerRB = GetComponent<Rigidbody>();

        //GoalTransform = GameObject.Find("TP").transform;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            Debug.Log("hit " + otherPortal.name);
            //other.transform.position = other.transform.position + new Vector3(0, 100, 0);
            //playerRB.AddForce(Vector3.up * 100, ForceMode.Impulse);

        }

    }
}
