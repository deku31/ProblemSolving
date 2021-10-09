using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballfollowP5 : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 dir;
    public float speed;
    public Transform point;
    void Start()
    {
        //mengamb komponene rigibody2d
        rb = GetComponent<Rigidbody2D>();
        //mengatur posisi objek ditengah
        transform.position = new Vector3(0, 0, 0);
        point.position = transform.position;
    }
    private void Update()
    {
        //mengubah posisi point ketempat posisi mouse di klik 
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //membaca posisi mouse
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            point.position = mousePosition;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        dir = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(dir.x * speed , dir.y * speed );
    }
}
