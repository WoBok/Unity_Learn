using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    protected virtual void Start()
    {
        Debug.Log("<color=#00FF00>Start</color>");
        Debug.Log("There is a debug print. I am <color=lime>lime color text</color>. I am <b>blod text</b>. I am <i>italic text</i>. <size=13>My size is 13</size>");
    }
    void Update()
    {

    }
}
