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
    public Text best;
    public GameManager manager;
    public static GUIManager instance = null;
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
    public void TimerStart(double timer)
    {
        time.text = timer.ToString();
    }
    public void Best(double best_t)
    {
        best.text = best_t.ToString();
    }
}
