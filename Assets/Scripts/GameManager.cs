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
    public GameObject umanager;
    GameObject text_time;
    GameObject text_playerTotalCount;
    GameObject guimng;
    GameObject tmng;
    GameObject smng;
    GameObject gameM;
    GameObject aa;
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentSceneName = currentScene.name;
        if (currentSceneName != "StartMenu")
        {
            text_time = GameObject.Find("Time");
            timee=GameObject.Find("GUIMng");
            timee.GetComponent<GUIManager>().time = text_time.GetComponent<Text>();
        
            text_playerTotalCount = GameObject.Find("PlayerScore");
            score=GameObject.Find("GUIMng");
            score.GetComponent<GUIManager>().playerTotalCount = text_playerTotalCount.GetComponent<Text>();

            guimng = GameObject.Find("GUIMng");
            tmng = GameObject.Find("TimeManger");
            tmng.GetComponent<TimeManager>().guiM = guimng.GetComponent<GUIManager>();

            smng = GameObject.Find("SceneManager");
            tmng = GameObject.Find("TimeManger");
            tmng.GetComponent<TimeManager>().SManger = smng.GetComponent<SceneManger>();

            gameM = GameObject.Find("GameManager");
            tmng = GameObject.Find("TimeManger");
            tmng.GetComponent<TimeManager>().gmanger = gameM.GetComponent<GameManager>();

            umanager = GameObject.Find("UserInform");
            tmng = GameObject.Find("TimeManger");
            tmng.GetComponent<TimeManager>().umanager = umanager.GetComponent<UserInformantion>();
        }

        gameM = GameObject.Find("GameManager");
        guimng = GameObject.Find("GUIMng");
        guimng.GetComponent<GUIManager>().manager = gameM.GetComponent<GameManager>();
        
        umanager = GameObject.Find("UserInform");
        aa = GameObject.Find("a");
        aa.GetComponent<Manager>().umanager = umanager.GetComponent <UserInformantion>();
    }
}