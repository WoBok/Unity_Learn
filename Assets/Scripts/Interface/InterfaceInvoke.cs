using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceInvoke : MonoBehaviour
{
    private void Start()
    {
        IInterface1 a = new Implement1();
        a.OnEvent1();
    }
}

public interface IInterface1
{
    void OnEvent1();
}
public class Implement1 : IInterface1
{
    public void OnEvent1()
    {
        Debug.Log("<color=#O3JF2>Implement1</color>");
    }
}
public class Implement2 : IInterface1
{
    public void OnEvent1()
    {
        Debug.Log("<color=#O3JF2>Implement2</color>");
    }
}