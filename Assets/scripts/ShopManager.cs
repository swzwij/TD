using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject Shop;
    public Camera Cam1;
    public Camera Cam2;

    public GameObject TurretTower;

    public Transform Spawnpoint_0;

    public UImanaager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UImanaager>();
        print(uimanager.CurrentMana);

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

    public void Grid_0()
    {   
        if(uimanager.CurrentMana >= 150     )
        {
            GameObject UI = GameObject.Find("GameManager");
            UImanaager uimanager = UI.GetComponent<UImanaager>();
            uimanager.CurrentMana -= 150;

            Instantiate(TurretTower, Spawnpoint_0.position, Quaternion.identity);
        }   
    }
}
