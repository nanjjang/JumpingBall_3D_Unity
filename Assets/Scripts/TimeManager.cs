using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class TimeManager : MonoBehaviour
{
    public SceneManger SManger;
    public GameManager gmanger;
    public static TimeManager instance = null;
    double timer = 0f;
    public GUIManager uiManager;
    int bestTime = 0;
    int lastTime = 0;

    void Awake()
    {
        Load();
        Debug.Log(bestTime);

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void Update()
    {
        if (!SManger.subMenu.activeSelf)
        {
            timer += Time.deltaTime;
            uiManager.TimerStart((int)timer);
        }
    }

    public void TimeStop()
    {
        lastTime = (int)timer;
        myTime = lastTime;
    }

    public static TimeManager Instance()
    {
        return instance;
    }

    public int best_time
    {
        get { return bestTime; }
    }

    public int myTime
    {
        get { return lastTime; }
        set
        {
            lastTime = value;
            if (bestTime == 0 || lastTime < bestTime)
            {
                bestTime = lastTime;
                Debug.Log("최고점수는?:" + bestTime);
                Save();
                
            }
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Best Time", bestTime);
        PlayerPrefs.SetString("Nickname", gmanger.nickname);
    }

    public void Load()
    {
        bestTime = PlayerPrefs.GetInt("Best Time", 0);
        PlayerPrefs.GetString("Nickname", "0");
    }
}