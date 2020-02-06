using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveElements : MonoBehaviour
{

    public int movementLength = 5;
    public int movementSpeed = 5;

    private float startPoint;
    private float endPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position.x;
        endPoint = transform.position.x + movementLength;
    }

    // Update is called once per frame
    void Update()
    {
        // For a different direction, change the Mathf.PingPong to another axis and change "startPoint" and "endPoint" to another axis

        transform.position = new Vector3(Mathf.PingPong(Time.time * movementSpeed, endPoint - startPoint) + startPoint, transform.position.y, transform.position.z);

    }
}
