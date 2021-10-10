using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanagerP6 : MonoBehaviour
{
    //prefab dari cube
    public GameObject cube;
    //jumlah cube yang keluar
    private int cubelength;
    //jumlah maksimal cube
    public int jumlahCube;
    //untuk menghitung cube yang keluar
    private GameObject[] getCount;

    void Start()
    {
        //mengacak jumlah maksimal cube
        jumlahCube = Random.Range(1, 10);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        getCount = GameObject.FindGameObjectsWithTag("cube");
        cubelength = getCount.Length;
        //memunculkan cube
        if (cubelength<jumlahCube)
        {
            Instantiate(cube);
        }
    }
}
