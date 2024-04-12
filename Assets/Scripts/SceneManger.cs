using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManger : MonoBehaviour
{
    public GameObject subMenu;

    public void In_game()
    {
        SceneManager.LoadScene("Ingame1");

    }
    public void Set()
    {
        SceneManager.LoadScene("Setting");
    }
    
    public void exit()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Cancel"))
            if(subMenu.activeSelf)
                subMenu.SetActive(false);
            else subMenu.SetActive(true);

        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;

    }
}
