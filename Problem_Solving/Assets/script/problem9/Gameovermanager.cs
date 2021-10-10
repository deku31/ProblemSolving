using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameovermanager : MonoBehaviour
{
    public Image gameoverpanel;
    public Text gameovertxt, title;

    public bool isGameover;
    private void Start()
    {
        isGameover = false;
    }
    void gameover() 
    {
        if (isGameover==true)
        {
            gameoverpanel.enabled = true;
            gameovertxt.enabled = true;
            title.enabled = true;
        }
        else
        {
            gameovertxt.enabled = false;
            title.enabled = false;
            gameoverpanel.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        gameover();
    }
}
