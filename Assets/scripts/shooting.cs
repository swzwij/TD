using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public bool SeeEnemy = false;
    public Transform firepoint;
    public float fireRate = 0.1F;
    private float nextFire = 0.0F;

    void Start()
    {
        nextFire = Time.time;
    }

    void Update()
    {


        if (SeeEnemy && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
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
