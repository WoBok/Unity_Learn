using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void DoSometing(int value);

public class AnonymousMethod : MonoBehaviour
{
    DoSometing doSometing;
    void Start()
    {
        doSometing += value => { print($"value:{++value}"); };
        doSometing += value => { print($"value:{++value}"); };
        doSometing += value => { print($"value:{++value}"); };
        doSometing += value => { print($"value:{++value}"); };
        doSometing += value => { print($"value:{++value}"); };
        doSometing += Calculate;
    }
    void Calculate(int value)
    {
        print($"Calculate,value:{++value}");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            doSometing?.Invoke(10);
        }
    }
}
