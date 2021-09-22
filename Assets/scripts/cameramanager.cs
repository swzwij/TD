using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanager : MonoBehaviour
{
    public Camera Cam1;
    public Camera Cam2;

    void Start()
    {
        Cam1.GetComponent<Camera>().enabled = true;
        Cam2.GetComponent<Camera>().enabled = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad1))
        {
            //Debug.Log("pressed 1");
            Cam1.GetComponent<Camera>().enabled = false;
            Cam2.GetComponent<Camera>().enabled = true;
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            //Debug.Log("Pressed 2");
            Cam2.GetComponent<Camera>().enabled = false;
            Cam1.GetComponent<Camera>().enabled = true;
        }
    }
}
