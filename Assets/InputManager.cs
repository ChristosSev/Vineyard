﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
     public float throttle;
     public float steer;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
       throttle = Input.GetAxis("Vertical");
       steer = Input.GetAxis("Horizontal");
       
       
    }
}

