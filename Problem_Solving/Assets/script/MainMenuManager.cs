﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void gotoscane(int tujuan) 
    {
        Application.LoadLevel(tujuan);
    }
}
