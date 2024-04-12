using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public int totalItemCount;
    public Text stageTotalCount;
    public Text playerTotalCount;
    public Text time;
    public TimeManager tManager;
    void Awake()
    {
        stageTotalCount.text = "/ " + totalItemCount;
    }
    public void GetItem(int count)
    {
        playerTotalCount.text = count.ToString();
    }
    public void TimerStart(float timer)
    {
        time.text = timer.ToString();
    }
}
