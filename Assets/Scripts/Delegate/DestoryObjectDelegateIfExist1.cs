using System;
using UnityEngine;

public class DestoryObjectDelegateIfExist1 : MonoBehaviour
{
    public DestoryObjectDelegateIfExist exist;
    void Start()
    {
        exist.action += Fun1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(exist.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            exist.action?.Invoke();
        }
    }
    public void Fun1()
    {
        Debug.Log("DestoryObjectDelegateIfExist1");
    }
}