using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerP8 : MonoBehaviour
{
    //mencegah munculnya cube di posisi ball
    public Transform ball;

    //mengatur agar cube muncul setiap 3 detik
    public float time = 3f;
    public bool p;

    //mengatur cube
    public GameObject cube;
    private int cubelength;
    public int jumlahCube;
    private GameObject[] getCount;

    //posisi random cube
    public float horizontal=0;
    public float vertical;
    private float ranx, rany;

    //kondisi dimana cube bertambah atau tidak
    public bool tambah;
    //score
    public int score;
    public Text scoreTxt;


    void Start()
    {
        tambah = true;
        jumlahCube = Random.Range(4, 10);
       
    }
    // Start is called before the first frame update
   // Update is called once per frame
    void Update()
    {
        ranx = Random.Range(-horizontal, horizontal);
        rany = Random.Range(-vertical, vertical);
        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
       
        getCount = GameObject.FindGameObjectsWithTag("cube");
        cubelength = getCount.Length;
        if (cubelength < jumlahCube && tambah == true)
        {
            
            if(ranx>2+transform.position.x||ranx<-2+transform.position.x)
            {
                Instantiate(cube, new Vector2(ranx, rany), Quaternion.identity);
            }
        }
        else if (cubelength == jumlahCube)
        {
            tambah = false;
            time = 3f;

        }

        if (time > 0 && p == false)
        {
            time -= 0.05f;
        }
        else if(time<=0)
        {
            tambah = true;
        }
        scoreTxt.text = score.ToString();
        IEnumerator ToSpawnTrue()
        {
            yield return new WaitForSeconds(0.75f);
            tambah = true;
        }
    }
    
}
