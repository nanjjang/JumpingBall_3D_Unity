using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    float timer = 0f;
    // Start is called before the first frame update
    public void Timer()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
    }
}
