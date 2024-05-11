using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public void FullScreen()
    {
        Screen.fullScreen = true;
    }
    public void PopUpScreen()
    {
        Screen.fullScreen = false;
    }
}
