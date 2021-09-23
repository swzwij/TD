using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerShooting : MonoBehaviour
{
    public GameObject bullet;
    public bool SeeEnemy;
    public Transform firepoint;

    void Update()
    {
        if (SeeEnemy == true)
        {
            //Debug.Log("see enemy");
            Shoot();
        }

        SeeEnemy = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("see enemy"); 
            SeeEnemy = true;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firepoint.position, Quaternion.identity);
    }
}
