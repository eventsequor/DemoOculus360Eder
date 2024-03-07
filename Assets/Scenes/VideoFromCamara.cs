using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoFromCamara : MonoBehaviour
{

    static WebCamTexture webCamTexture; // This is the webcam that the computer can identify
    public Material camMaterial;  // Skybox material, this could be a sphere or other similar element

    void Start()
    {
        Debug.Log("Starting camera");
        if (webCamTexture == null)
            webCamTexture = new WebCamTexture(WebCamTexture.devices[0].name, 1280, 720); 
            //WebCamTexture.devices[0].name this get the first camera connected
            // 1280, 720 the resolution should be similar to streaming channel 

        if (!webCamTexture.isPlaying)
            webCamTexture.Play(); // Play camera

	if (camMaterial != null)
            camMaterial.mainTexture = webCamTexture; // set texture to material

    }

}