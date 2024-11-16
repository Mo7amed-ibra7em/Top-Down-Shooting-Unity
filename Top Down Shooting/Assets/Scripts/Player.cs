using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 5f;
    Rigidbody2D Rb;
    public Camera Camera;
    Vector2 Movement;
    Vector2 MovePos;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        MovePos = Camera.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + Movement * Speed * Time.deltaTime);
        Vector2 LookTo = MovePos - Rb.position;
        float Angle = Mathf.Atan2(LookTo.y, LookTo.x) * Mathf.Rad2Deg - 90f;
        Rb.rotation = Angle;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            GameControl.Health -= 0.1f;
        }
    }
}
