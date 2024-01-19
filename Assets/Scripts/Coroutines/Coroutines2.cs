using System.Collections;
using UnityEngine;

public class Coroutines2 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Coroutines2 Awake");
    }
    void OnEnable()
    {
        Debug.Log("Coroutines2 OnEnable");
    }
    void Start()
    {
        Debug.Log("Coroutines2 Start");
        StartCoroutine(Coroutine());
    }
    void Update()
    {
        for (int i = 0; i < 100000000; i++)
        {

        }
        CoroutinesTimePrinter.PrintTime("Coroutines2 Update");
    }
    void FixedUpdate()
    {
        CoroutinesTimePrinter.PrintTime("Coroutines2 FixedUpdate", "orange");
    }
    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            CoroutinesTimePrinter.PrintTime("Coroutines3 WaitForFixedUpdate", "magenta");
        }
    }
}