using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloner : MonoBehaviour
{

    //public GameObject Player;
    //public GameObject Camera;

    public Transform playerCamera;
    public Transform portal;
    public Transform portal2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerOffsetFromPortal = playerCamera.position - portal2.position;
        transform.position = portal.position + playerOffsetFromPortal;

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, portal2.rotation);

        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

        //Camera.transform.localPosition = Player.transform.localPosition;
        //Camera.transform.localRotation = Camera.transform.localRotation;
        //Camera.transform.localScale = Player.transform.localScale;
    }
}
