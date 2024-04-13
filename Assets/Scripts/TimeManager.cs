using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

public class TimeManager : MonoBehaviour
{
    public SceneManger SManger;
    public static TimeManager instance = null;
    double timer = 0;
    public double timer_t;
    public GUIManager manager;
    double bestTime = 111111;
    int countt=0;
    // Start is called before the first frame update
    void Awake()
    {
        manager = GetComponent<GUIManager>();
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
            LoadBestTime();
        }
        Debug.Log("최고점수는?:" + bestTime);
    }
    void Update()
    {
        if (!SManger.subMenu.activeSelf){
            timer += Time.deltaTime;
            timer_t = Math.Truncate(timer);
            manager.TimerStart(timer_t);
        }
    }

    public static TimeManager Instance()
    {
        return instance;
    }
    public double best_time
    {
        get
        {
            return bestTime;
        }
    }
    public double myTime
    {
        get
        {
            return timer_t;
        }
        set
        {
            timer_t = value;

            if(timer_t < bestTime)
            {
                bestTime = timer_t;
                SaveBestTime();
                Debug.Log(bestTime);
            }
        }
    }
    void SaveBestTime()
    {
        PlayerPrefs.SetString("Best Time", bestTime.ToString());
        manager.Best(bestTime);
    }
    void LoadBestTime()
    {
        string bestTimeAsString = PlayerPrefs.GetString("Best Time");
        bestTime = double.Parse(bestTimeAsString);
    }
}