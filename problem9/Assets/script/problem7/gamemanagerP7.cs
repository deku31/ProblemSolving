using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanagerP7 : MonoBehaviour
{
    //mengatur cube
    public GameObject cube;
    private int cubelength;
    public int jumlahCube;
    private GameObject[] getCount;
    //kondisi dimana cube bertambah atau tidak
    public bool tambah;
    //score
    public int score;
    public Text scoreTxt;


    void Start()
    {
        tambah = true;
        jumlahCube = Random.Range(1, 10);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        getCount = GameObject.FindGameObjectsWithTag("cube");
        cubelength = getCount.Length;
        
        print(cubelength.ToString());
        if (cubelength<jumlahCube&&tambah==true)
        {
            Instantiate(cube);
        }
        else if (cubelength==jumlahCube)
        {
            tambah = false;
        }
        scoreTxt.text = score.ToString();
    }
}
