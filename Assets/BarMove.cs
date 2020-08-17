using System.Collections;
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
        rb.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = transform.right * 20;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = transform.right*-1*20;
        }
    }
}
