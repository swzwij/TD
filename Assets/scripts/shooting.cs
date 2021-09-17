using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public bool SeeEnemy = false;
    private float nextActionTime = 0.1f;
    public float period = 0.1f;

    void Update()
    {

        if (SeeEnemy == true)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                //StartCoroutine(ShootDelay());
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
