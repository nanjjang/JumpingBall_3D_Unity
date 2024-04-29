using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public UserInformantion umanager;
    public string player_name;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void save()
    {
        umanager.Load();
        player_name = umanager.nicknameInputField.text;
        Debug.Log(player_name);
    }
    void Update()
    {
        umanager.Load();
        if (Input.GetKey("q"))
        {
            Debug.Log(umanager.nicknameInputField.text);
        }

    }
}