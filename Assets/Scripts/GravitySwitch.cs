using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitch : MonoBehaviour
{
    public float force = 9.81f;
    public int speed = 2;
    private Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int verticalInput = (int)Input.GetAxis("Vertical");
        int horizontalInput = (int)Input.GetAxis("Horizontal");
        playerRB.AddForce(Vector3.right * speed * horizontalInput * 0.1f, ForceMode.Impulse);
        playerRB.AddForce(Vector3.forward * speed * verticalInput * 0.1f, ForceMode.Impulse);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.CompareTag("zMinus"))
        {
            playerRB.AddForce(Vector3.forward * -1 * force, ForceMode.Impulse);
            transform.Rotate(Vector3.right * 90);
        }
        if (other.gameObject.CompareTag("zPlus"))
        {
            playerRB.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("xMinus"))
        {
            playerRB.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("xPlus"))
        {
            playerRB.AddForce(Vector3.right * -1 * force, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Top"))
        {
            playerRB.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Bottom"))
        {
            playerRB.AddForce(Vector3.up * -1 * force, ForceMode.Impulse);
        }

    }
}
