﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform topunkonumu;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - topunkonumu.position;
    }

    void Update()
    {
        if(TopHareketi.düştü_mü == false)
        {
            transform.position = topunkonumu.position + fark;
        }
    }
}
