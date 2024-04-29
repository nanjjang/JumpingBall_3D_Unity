using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UserInformantion : MonoBehaviour
{
    public InputField nicknameInputField;
    void input(InputField input) // enter 쳤을때 호출.
    {
        Save();
        if (input.text.Length > 0)
        {
            Debug.Log(input.text);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("입력 하세요");
        }
    }
    void Start()
    {        
        nicknameInputField.onSubmit.AddListener(delegate { input(nicknameInputField); });
    }
    public void Save()//닉네임 저장
    {
        PlayerPrefs.SetString("Nick Name", nicknameInputField.text);
    }

    public void Load()//저장된 닉네임 불러오기
    {
        nicknameInputField.text = PlayerPrefs.GetString("Nick Name", "0");
    }
}