using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject Superbullet;
    public Transform firepoint;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //Debug.Log("Bullet Hit portal");
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(Superbullet, firepoint.position, Quaternion.identity);
    }
}
