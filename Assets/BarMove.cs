using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public BallMove ballMove;
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "HeartItem")
        {
            ballMove.playCount = ballMove.playCount + 1;
            ballMove.playCountText.text = "playCount:" + ballMove.playCount;
        }
    }
}
