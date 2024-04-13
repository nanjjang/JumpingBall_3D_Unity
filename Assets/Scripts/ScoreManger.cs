using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManger : MonoBehaviour
{
    public int itemCount;
    public GUIManager manager;

    public void Score()
    {
        itemCount++;
        manager.GetItem(itemCount);
    }

}
