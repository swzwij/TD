using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public bool SeeEnemy;
    private float nextActionTime = 0.1f;
    public float period = 0.1f;

    void Update()
    {
        

        if (SeeEnemy == true)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                Shoot();
            }
        }

        SeeEnemy = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("see enemy"); 
            SeeEnemy = true;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
