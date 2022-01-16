using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
