﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCOntroller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "ball")
        {
            Destroy(gameObject);
        }
    }
}
