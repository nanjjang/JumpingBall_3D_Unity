using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public UserInformantion umanager;
    public string player_name;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }
    public void Name()
    {
        player_name = umanager.nicknameInputField.text;
    }
}