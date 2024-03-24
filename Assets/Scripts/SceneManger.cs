using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public void Ingame()
    {
        SceneManager.LoadScene("Ingame-1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
