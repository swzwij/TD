using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject Shop;
    public Camera Cam1;
    public Camera Cam2;

    private void Start()
    {
        Cam1.GetComponent<Camera>().enabled = true;
        Cam2.GetComponent<Camera>().enabled = false;
    }

    public void OpenShop()
    {
        print("Opened shop");

        Shop.SetActive(true);

        Cam1.GetComponent<Camera>().enabled = false;
        Cam2.GetComponent<Camera>().enabled = true;
    }

    public void CloseShop()
    {
        print("Closed shop");

        Shop.SetActive(false);

        Cam2.GetComponent<Camera>().enabled = false;
        Cam1.GetComponent<Camera>().enabled = true;
    }
}
