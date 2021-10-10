using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randompositioncubeP6 : MonoBehaviour
{
    float x;
    float y;
    float z;
    //letak posisi cube
    Vector3 pos;
    void Start()
    {
        //agar mengacak posisi x dan y ketika cube muncul
        x = Random.Range(-7.5f, 7.35f);
        y = Random.Range(-3.53f,3.92f);
        z = 0;
        pos = new Vector3(x, y, z);
        transform.position = pos;
    }
}
