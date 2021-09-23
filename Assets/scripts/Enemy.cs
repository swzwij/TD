using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int speed = 1;

    public GameObject HealthBar1;
    public GameObject HealthBar2;
    public GameObject HealthBar3;
    public GameObject HealthBar4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }

        transform.position += Vector3.back * speed * Time.deltaTime;
        
        if(health <= 75)
        {
            HealthBar1.SetActive(false);
        }

        if (health <= 50)
        {
            HealthBar2.SetActive(false);
        }

        if (health <= 25)
        {
            HealthBar3.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //Debug.Log("Hit");
            health = health - 3;
        }
    }
    
}
