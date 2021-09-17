using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTrigger : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("See Enemy");

            GameObject turret = GameObject.Find("turret");
            shooting Shooting = turret.GetComponent<shooting>();
            shooting.SeeEnemy = true;
        }
    }

    void Update()
    {
        GameObject turret = GameObject.Find("turret");
        shooting Shooting = turret.GetComponent<shooting>();
        shooting.SeeEnemy = false;
    }

    
}
