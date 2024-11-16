using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Bullet;
    Rigidbody2D Rb;
    float SpeedBullet = 30f;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Fire = Instantiate(Bullet, transform.position, transform.rotation);
            Rb = Fire.GetComponent<Rigidbody2D>();
            Rb.AddForce(transform.up * SpeedBullet, ForceMode2D.Impulse);
            Destroy(Fire, 0.5f);
        }
    }
}
