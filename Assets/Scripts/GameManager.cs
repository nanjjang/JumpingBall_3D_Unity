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
    void Awake()
    {
        GameObject text_time = GameObject.Find("Time");
        guiM.time = text_time.GetComponent<Text>();
        GameObject text_playerTotalCount = GameObject.Find("PlayerScore");
        guiM.playerTotalCount = text_playerTotalCount.GetComponent<Text>();
        score=GameObject.Find("GUIMng");
        score.GetComponent<GUIManager>().playerTotalCount = text_playerTotalCount.GetComponent<Text>();
        timee=GameObject.Find("GUIMng");
        timee.GetComponent<GUIManager>().time = text_time.GetComponent<Text>();
    }
    
}