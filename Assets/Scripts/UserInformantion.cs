using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserInformantion : MonoBehaviour
{
    public InputField nicknameInputField;
    void Input(InputField input) // enter ������ ȣ��.
    {                                                                   
        if (input.text.Length > 0)
        {
            Debug.Log(input);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("�Է� �ϼ���");
        }
    }
    void Start()
    {
        nicknameInputField.onSubmit.AddListener(delegate { Input(nicknameInputField); });
    }
}