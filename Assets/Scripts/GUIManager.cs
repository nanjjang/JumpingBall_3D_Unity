using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    //public int totalItemCount;
    //public Text stageTotalCount;
    public Text playerTotalCount;
    public Text time;
    public GameManager manager;
    public static GUIManager instance = null;
    public Text nAme;

    /*void Awake()
    {
        stageTotalCount.text = "/ " + totalItemCount;
    }*/

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        /*else
        {
            if (instance != null)
            {
                Destroy(this.gameObject);
            }
        }*/
    }

    public void GetItem(int count)
    {
        playerTotalCount.text = count.ToString();
    }
    public void TimerStart(int timer)
    {
        time.text = timer.ToString();
    }
    public void Ranking(string nickname, int time)
    {
        nAme.text = nickname.ToString() + time;
    }
}