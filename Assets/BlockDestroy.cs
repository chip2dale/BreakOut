using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        hp=hp-1;
        if (hp == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
