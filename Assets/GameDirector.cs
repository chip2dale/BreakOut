using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    int BlockCount;
    public GameObject ClearText;
    // Start is called before the first frame update
    void Start()
    {
        BlockCount = GameObject.FindGameObjectsWithTag("Block").Length;
        print(BlockCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecreaseCount()
    {
        BlockCount--;
        if (BlockCount == 0)
        {
            ClearText.SetActive(true);
        }
        print(BlockCount);
    }
}
