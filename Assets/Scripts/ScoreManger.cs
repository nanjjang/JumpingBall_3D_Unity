using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    public int itemCount;
    public GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Score()
    {
        itemCount++;
        manager.GetItem(itemCount);
    }

}
