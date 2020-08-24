﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public int playCount;
    // Start is called beforep the first frame update
    public Rigidbody rb;
    float startvelocity;
    public GameDirector gameDirector;
    void Start()
    {
        playCount = 3;
        rb.AddForce(6, 0, -15, ForceMode.Impulse);
        startvelocity = 10;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (rb.velocity.magnitude < startvelocity)
        {
            rb.AddForce(rb.velocity.normalized*10);
        }
    }
    private void OnTriggerEnter(Collider other)　//衝突判定　通り抜ける　当たっととき
    {
        if (other.tag == "DeleteZone")
        {
            StartCoroutine(Reset());        //Restartコルーチンを始める
            playCount = playCount - 1;
            if (playCount == 0)
            {
                gameDirector.GameOver();
            }
        }
    }
    //コルーチン
    IEnumerator Reset()
    {
        transform.position = new Vector3(0, 1, 0);
        rb.velocity = Vector3.zero; //speedをゼロにする
        yield return new WaitForSeconds(2f);
        rb.AddForce(Random.Range(-10,10), 0, -10, ForceMode.Impulse);

    }
}