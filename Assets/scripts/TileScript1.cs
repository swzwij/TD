using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript1 : MonoBehaviour
{
    public GameObject TurretTower;

    public Transform Spawnpoint;
    private bool _IsBuildeble = true;

    void OnMouseDown()
    {
        BuildTower();
    }

    void BuildTower()
    {
        GameObject UI = GameObject.Find("GameManager");
        UImanaager uimanager = UI.GetComponent<UImanaager>();

        if (uimanager.CurrentMana >= 100 && _IsBuildeble == true)
        {
            Instantiate(TurretTower, Spawnpoint.position, Quaternion.identity);
            _IsBuildeble = false;
            uimanager.CurrentMana -= 100;
        }
    }
}
