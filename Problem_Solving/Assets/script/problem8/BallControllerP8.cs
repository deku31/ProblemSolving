using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControllerP8 : MonoBehaviour
{
    public float speed = 6f;
    public bool kena;
    public ballfollowP8 bf;
    public gamemanager gm;

    public Gameovermanager go;
    public GameObject prefabCube;
    void Start()
    {
        //mengubah posisi dingah ketika awal permainan
        transform.localPosition = new Vector3(0, 0, 0);
    }
    private void FixedUpdate()
    {
        if (gm.gameplay==true)
        {
            //menginput objek bergerak horizontal
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                bf.run = false;
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                bf.run = false;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            //minginput objek bergerak vertical
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                bf.run = false;
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                bf.run = false;
                transform.Translate(Vector2.up * -speed * Time.deltaTime);
            }
        }
    }
    //menambahkan score
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "cube")
        {
            gm.score += 1;
            gm.p = false;
        } 
        if (collision.transform.tag == "enemy")
        {
            Destroy(gameObject);
            go.isGameover = true;
        }
    }
}
