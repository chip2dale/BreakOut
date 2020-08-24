using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    int BlockCount;
    public GameObject ClearText;
    public GameObject GameOverText;
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
    public void GameOver()
    {
        GameOverText.SetActive(true);
        StartCoroutine(Restart());
    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("SampleScene");

    }
}
