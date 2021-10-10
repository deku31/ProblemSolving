using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problem3 : MonoBehaviour
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
        transform.localPosition = new Vector3(0, 0, 0);

        Invoke("gerak", 0);
    }
    void gerak()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);


        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(xInitialForce, yRandomInitialForce) * speed);
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yRandomInitialForce) * speed);
        }

        if (rigidBody2D.velocity.magnitude != speed)
        {
            rigidBody2D.velocity = rigidBody2D.velocity.normalized * speed;
        }
    }
}
