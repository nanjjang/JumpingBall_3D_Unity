using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserInformantion : MonoBehaviour
{
    public InputField nicknameInputField;
    public Manager manager;
    void Input(InputField input) // enter ������ ȣ��.
    {
        
        if (input.text.Length > 0)
        {
            Debug.Log(input.text);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("�Է� �ϼ���");
        }
        manager.Name();
    }
    void Start()
    {
        nicknameInputField.onSubmit.AddListener(delegate { Input(nicknameInputField); }) ;
    }
}