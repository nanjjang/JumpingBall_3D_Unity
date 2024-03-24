using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public Text stageTotalCount;
    public Text playerTotalCount;
    void Awake()
    {
        stageTotalCount.text = "/ " + totalItemCount;    
    }
    // Update is called once per frame
    public void GetItem(int count)
    {
        playerTotalCount.text=count.ToString();
    }
}
