using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GUIManager guiM;
    public GameObject timee;
    public GameObject score;
    public GameObject gmng;
    void Awake()
    {
        GameObject text_time = GameObject.Find("Time");
        timee=GameObject.Find("GUIMng");
        timee.GetComponent<GUIManager>().time = text_time.GetComponent<Text>();
        
        GameObject text_playerTotalCount = GameObject.Find("PlayerScore");
        score=GameObject.Find("GUIMng");
        score.GetComponent<GUIManager>().playerTotalCount = text_playerTotalCount.GetComponent<Text>();

        gmng = GameObject.Find("GUIMng");
        GameObject tmng = GameObject.Find("TimeManger");
        tmng.GetComponent<TimeManager>().uiManager = gmng.GetComponent<GUIManager>();

        GameObject smng = GameObject.Find("SceneManager");
        tmng = GameObject.Find("TimeManger");
        tmng.GetComponent<TimeManager>().SManger = smng.GetComponent<SceneManger>();

        GameObject gameM = GameObject.Find("GameManager");
        gmng = GameObject.Find("GUIMng");
        gmng.GetComponent<GUIManager>().manager = gameM.GetComponent<GameManager>();
    }

    //´Ð³×ÀÓ
    public InputField nicknameInputField;
    public string nickname = "NULL";
    void Start()
    {
        TimeManager.instance.Load();
        nicknameInputField.text = nickname;
        GUIManager.instance.Nickname(nickname,TimeManager.instance.best_time);
    }
    
}