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
        int verticalInput = (int) Input.GetAxis("Vertical");
        int horizontalInput = (int) Input.GetAxis("Horizontal");
        playerRB.AddForce(Vector3.right * speed * horizontalInput * 0.1f, ForceMode.Impulse);
        playerRB.AddForce(Vector3.forward * speed * verticalInput * 0.1f, ForceMode.Impulse);
    }

    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.CompareTag("zMinus"))
        {
            playerRB.AddForce(Vector3.forward * -1 * force, ForceMode.Impulse);
        }
    }
    
}
