using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private bool playing = false;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        StopAllCoroutines();
        playing = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        playing = true;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
