using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    double timer = 0;
    double timer_t=0;
    // Start is called before the first frame update
    void Update()
    {
        timer += Time.deltaTime;
        timer_t  = Math.Truncate(timer);
        Debug.Log(timer_t);
    }
}