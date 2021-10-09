using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompositioncubeP7 : MonoBehaviour
{
    public int score;
    float x;
    float y;
    float z;
    Vector3 pos;
    void Start()
    {
        x = Random.Range(-7.5f, 7.35f);
        y = Random.Range(-3.53f,3.92f);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
    //menghancurkan cube
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "ball")
        {
            print("hancur");
            score = 1;
            Destroy(gameObject);
        }
    }
}
