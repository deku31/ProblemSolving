using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
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
    public float horizontal = 0;
    public float vertical;
    private float ranx, rany;

    //kondisi dimana cube bertambah atau tidak
    public bool tambah;
    public bool tambahenemy;
    //score
    public int score;
    public Text scoreTxt;
    //jumlah bullet
    public Image iconbullet;
    public Text bullettxt;
    public Sprite _icon;

    //memunclkan enemy
    [SerializeField]public enemyPush _enemy;
    public GameObject enemy; 
    private int lengthenemy;
    public int jumlahenemy;
    private GameObject[] getCountenemy;
    public float spawnenemy=0;

    //menambahkan peluru/bom
    public GameObject bullet;
    public Bullet peluru;
    public Transform target;
    public GameObject player;
    public int jumlahbullet;
    private int lengthbullet;
    public bool tambahbullet;
    private GameObject[] getCountBullet;

    //gameplay
    public bool gameplay;
    public GameObject Playscreen;

    void Start()
    {
        iconbullet.sprite = _icon;
        tambah = true;
        jumlahCube = Random.Range(4, 10);
        tambahbullet = true;
        gameplay = false;
    }
    public void playgame() 
    {
        gameplay = true;
        Playscreen.SetActive(false);

    }
    public void quit() 
    {
        Application.Quit();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    void Update()
    {
        
        if (gameplay == true)
        {
            ranx = Random.Range(-horizontal, horizontal);
            rany = Random.Range(-vertical, vertical);

            //memunculkan Bom
            getCountBullet = GameObject.FindGameObjectsWithTag("bullet");
            lengthbullet = getCountBullet.Length;
            peluru.targetpos = target;
            peluru.player = player;
            if (lengthbullet < jumlahbullet)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    Instantiate(bullet);
                }

            }
            else if (lengthbullet == jumlahbullet)
            {
                tambahbullet = false;
            }


            //memunculkan cube
            getCount = GameObject.FindGameObjectsWithTag("cube");
            cubelength = getCount.Length;
            if (cubelength < jumlahCube && tambah == true)
            {
                if (ranx > 2 + transform.position.x || ranx < -2 + transform.position.x)
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
            else if (time <= 0)
            {
                tambah = true;
            }

            //menaikan lv
            if (score == 100)
            {
                jumlahbullet *= 2;
                jumlahenemy += 1;

            }

            //memunculkan enemy
            getCountenemy = GameObject.FindGameObjectsWithTag("enemy");
            lengthenemy = getCountenemy.Length;
            if (lengthenemy < jumlahenemy && tambahenemy == true)
            {
                if (ranx > 2 + transform.position.x || ranx < -2 + transform.position.x)
                {
                    Instantiate(enemy, new Vector2(ranx, rany), Quaternion.identity);
                }
                spawnenemy = 5;
            }
            else if (lengthenemy == jumlahenemy)
            {
                tambahenemy = false;
                spawnenemy = 5;
            }
            else if (lengthenemy < jumlahenemy && spawnenemy <= 0)
            {
                tambahenemy = true;
            }

            if (spawnenemy > 0)
            {
                spawnenemy -= 0.05f;
            }
        }
        bullettxt.text = "X" + jumlahbullet.ToString();
        scoreTxt.text = "score : " + score.ToString();

    }
}
