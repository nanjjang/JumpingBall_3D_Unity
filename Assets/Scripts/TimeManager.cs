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
    public UserInformantion umanager;
    public static TimeManager instance = null;
    double timer = 0f;
    public GUIManager guiM;
    int bestTime ;
    string bestPlayer;
    int lastTime = 0;
    public Manager manager;
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
            guiM.TimerStart((int)timer);
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
                Debug.Log(manager.player_name);
                guiM.Ranking(manager.player_name, bestTime);
                Save();
            }   
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Best Time", bestTime);
        PlayerPrefs.SetString("Nick Name", manager.player_name);
    }

    public void Load()
    {
        bestTime = PlayerPrefs.GetInt("Best Time", 0);
        bestPlayer = PlayerPrefs.GetString("Nick Name", null);
    }
}