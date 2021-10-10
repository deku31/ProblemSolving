using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPush : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    //besar gaya dorongan awal pada bola
    public float xInitialForce;
    public float yInitialForce;
    public float speed;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void gerak()
    {
        float xrandom = Random.Range(-xInitialForce, xInitialForce);
        float yrandom = Random.Range(-yInitialForce, yInitialForce);
        // Gunakan gaya untuk menggerakkan linkaran.
        rigidBody2D.AddForce(new Vector2(xrandom, yrandom) * speed);
        if (rigidBody2D.velocity.magnitude != speed)
        {
            rigidBody2D.velocity = rigidBody2D.velocity.normalized * speed;
        }
    }
    void Update()
    {
        Invoke("gerak", 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="bullet")
        {
            Destroy(gameObject);
        }
    }
}
