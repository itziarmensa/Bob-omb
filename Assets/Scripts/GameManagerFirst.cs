using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerFirst : MonoBehaviour
{

    public static GameManagerFirst instance;


    private void Awake()
    {
        instance = this;
    }


    public IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("PrincipalScene");

    }

    void Update()
    {
        
    }
}
