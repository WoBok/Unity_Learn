using System;
using UnityEngine;

public class DestoryObjectDelegateIfExist : MonoBehaviour
{
    public Action action;
    public GameObject obj;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            action?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            Destroy(obj);
        }
    }
    public void Fun()
    {
        Debug.Log("1234567890");
    }
}