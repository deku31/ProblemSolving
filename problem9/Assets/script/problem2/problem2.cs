using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problem2 : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    //besar gaya dorongan awal pada bola
    public float xInitialForce;
    public float yInitialForce;
    public float speed;
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //mengubah posisi dingah ketika awal permainan
        transform.localPosition=new Vector3(0,0,0);
    }
    void gerak()
    {
        // Gunakan gaya untuk menggerakkan linkaran.
        rigidBody2D.AddForce(new Vector2(xInitialForce, yInitialForce) * speed);
        if (rigidBody2D.velocity.magnitude != speed)
        {
            rigidBody2D.velocity = rigidBody2D.velocity.normalized * speed;
        }
    }
    void Update()
    {
        Invoke("gerak", 0);
    }
}
