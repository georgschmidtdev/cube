using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{

    public Camera cameraRed;
    public Camera cameraGreen;

    public Material cameraMatRed;
    public Material cameraMatGreen;

    // Start is called before the first frame update
    void Start()
    {
        if (cameraRed.targetTexture != null)
        {
            cameraRed.targetTexture.Release();
        }
        cameraRed.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatRed.mainTexture = cameraRed.targetTexture;

        if (cameraGreen.targetTexture != null)
        {
            cameraGreen.targetTexture.Release();
        }
        cameraGreen.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGreen.mainTexture = cameraGreen.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
