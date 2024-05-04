using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserInformantion : MonoBehaviour
{
    public InputField nicknameInputField;
    public Manager manager;
    void Input(InputField input) // enter 쳤을때 호출.
    {
        
        if (input.text.Length > 0)
        {
            Debug.Log(input.text);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("입력 하세요");
        }
        manager.Name();
    }
    void Start()
    {
        nicknameInputField.onSubmit.AddListener(delegate { Input(nicknameInputField); }) ;
    }
}