using System;
using UnityEngine;

public class DestoryObjectDelegateIfExist2 : MonoBehaviour
{
    public DestoryObjectDelegateIfExist exist;
    public GameObject exist1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            exist.action?.Invoke();
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            exist.Fun();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Destroy(exist);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(exist1);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log(exist1.name);
        }
    }
}