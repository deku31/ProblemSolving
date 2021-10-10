using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform targetpos;
    private Vector3 mouseposition;
    public GameObject bullet;
    public Rigidbody2D rb;
    private Vector3 dir;
    public float speed;
    public bool gun;
    public GameObject player;

    private void Start()
    {
        transform.position = player.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="enemy")
        {
            Destroy(gameObject);
        }
    }
}
