using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanager : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;

    void Start()
    {
        Cam1.camera.enabled = true;
        Cam2.camera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            Cam1.camera.enabled = false;
            Cam2.camera.enabled = true;
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            Cam2.camera.enabled = false;
            Cam1.camera.enabled = true;
        }
    }
}
