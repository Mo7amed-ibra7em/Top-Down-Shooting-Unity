using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Blood;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explosion;
        if (collision.gameObject.tag != "Zombie")
        {
            explosion = Instantiate(Explosion, transform.position, transform.rotation );
            Destroy(explosion, 0.16f);
        }
        Destroy(gameObject);
        if (collision.gameObject.tag == "Zombie")
        {
            GameObject BloodEffect = Instantiate(Blood,collision.transform.position, collision.transform.rotation );
            Destroy(BloodEffect.gameObject, 0.11f);
            Destroy(collision.gameObject);
            GameControl.Score++;
        }
    }
}
