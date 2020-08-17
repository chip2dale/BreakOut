using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public GameDirector gameDirector;
    void Start()
    {
        if (hp == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (hp == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (hp == 3)
        {
            gameObject.GetComponent<Renderer>().material.color =Color .yellow;
        }
        if (hp == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 0.4f, 0.0f, 1.0f);
        }
        if (hp == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (hp == 0)
        {
            gameDirector.DecreaseCount();
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        hp = hp - 1;
        if (hp == 5)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if(hp == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if(hp == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (hp == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1.0f, 0.4f, 0.0f, 1.0f); 
        }
        if (hp == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (hp == 0)
        {
            gameDirector.DecreaseCount();
            Destroy(this.gameObject);
        }
    }
}
