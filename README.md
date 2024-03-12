# Video Streaming in real time camera Insta360 one x2 to Cculus Quest 2

###### Autor: Eder Leandro Carbonero Baquero

## Content table

1. Target of project
2. Tools used by solution
3. Devices 
4. No funtional requeriments or quality attributes
5. How to setup each tool?
6. Basic script


### 1. Target of project

The objective of this project is to show a video in 360 degrees, by using a VR device, the video on the glasses must show the transmission of the image in real time.

### 2. Tool used by solution

**Software**
- CosmoviewerNg
- Unity Editor: Version 2022.3.19f1

### 3. Devices
- Camera Insta360 one x2
- Oculus Quest 2

### 4. No functional requeriments or quality attributes

Computer with Windows 10 or higher

Procesor intel core i5 or higher

Memory RAM: Minimun 16 GB

Graphic card 2 GB 

### 5. How to setup each tool?

**CosmoviewerNg**

You have to setup you camera to show a video through a IP and port then you have to setup the format of transmition, in this case the rotation, also the image quality and create a virtual webcam 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.17.59 PM.jpeg>)

 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.18.20 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.18.39 PM (1).jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.18.39 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.18.52 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.22.02 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.22.20 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.24.28 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.25.02 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.25.31 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.25.51 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.26.22 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.26.50 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.27.56 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.28.16 PM.jpeg>) 
 
 ![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.28.37 PM.jpeg>)

**Unity**

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.31.15 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.35.09 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.31.34 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.34.51 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.34.22 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.33.53 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.33.34 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.33.02 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.32.28 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.32.15 PM.jpeg>) 

![alt text](<readme_sources/WhatsApp Image 2024-03-07 at 5.32.00 PM.jpeg>)

### 6. Script


``` c#
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

        if (!webCamTexture.isPlaying)
            webCamTexture.Play();

	if (camMaterial != null)
            camMaterial.mainTexture = webCamTexture;

    }

}
```