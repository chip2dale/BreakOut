using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    float startvelocity;
    void Start()
    {
        rb.AddForce(6, 0, -15, ForceMode.Impulse);
        startvelocity = 12;
        print(startvelocity);
    }

    // Update is called once per frame
    void Update()
    {
        print(rb.velocity.magnitude);
        if (rb.velocity.magnitude < startvelocity)
        {
            rb.AddForce(transform.forward*10);
        }
    }
    private void OnTriggerEnter(Collider other)　//衝突判定　通り抜ける　当たっととき
    {
        if (other.tag == "DeleteZone")
        {
            StartCoroutine(Reset());        //Restartコルーチンを始める
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