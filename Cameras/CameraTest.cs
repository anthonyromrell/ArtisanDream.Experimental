using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
  
        foreach(WebCamDevice cam in devices)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
