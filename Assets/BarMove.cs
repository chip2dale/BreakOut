﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0, ForceMode.Impulse);
        }
    }
}
