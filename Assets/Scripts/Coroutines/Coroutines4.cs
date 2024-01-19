using System.Collections;
using UnityEngine;

public class Coroutines4 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Coroutines4 Awake");
    }
    void OnEnable()
    {
        Debug.Log("Coroutines4 OnEnable");
    }
    void Start()
    {
        Debug.Log("Coroutines4 Start");
        StartCoroutine(Coroutine());
    }
    void Update()
    {
        for (int i = 0; i < 100000000; i++)
        {

        }
        CoroutinesTimePrinter.PrintTime("Coroutines4");
    }
    void FixedUpdate()
    {
        CoroutinesTimePrinter.PrintTime("Coroutines4 FixedUpdate", "orange");
    }
    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            CoroutinesTimePrinter.PrintTime("Coroutines4 WaitForSecondsRealtime", "yellow");
        }
    }
}