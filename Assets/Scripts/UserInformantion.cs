using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserInformantion : MonoBehaviour
{
    public InputField nicknameInputField;
    void input(InputField input) // enter ������ ȣ��.
    {
        Save();
        if (input.text.Length > 0)
        {
            Debug.Log(input.text);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("�Է� �ϼ���");
        }
    }
    void Start()
    {        
        nicknameInputField.onSubmit.AddListener(delegate { input(nicknameInputField); });
    }
    public void Save()//�г��� ����
    {
        PlayerPrefs.SetString("Nick Name", nicknameInputField.text);
    }

    public void Load()//����� �г��� �ҷ�����
    {
        nicknameInputField.text = PlayerPrefs.GetString("Nick Name", "0");
    }
}