﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloController : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = 1.1f + (Mathf.Cos(Time.time));

    }
}
