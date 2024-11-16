using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Transform PlayerPosition;
    Rigidbody2D Rb;
    float EnemySpeed = 3f;
    Vector2 MovmentEnemy;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 Direcition = PlayerPosition.position - transform.position;
        float Angle = Mathf.Atan2(Direcition.y, Direcition.x) * Mathf.Rad2Deg;
        Rb.rotation = Angle;
        Direcition.Normalize();
        MovmentEnemy = Direcition;
    }
    private void FixedUpdate()
    {
        Rb.MovePosition((Vector2)transform.position + (MovmentEnemy * EnemySpeed * Time.deltaTime));
    }
}
