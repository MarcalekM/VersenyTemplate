using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float Damage = 30;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
}
