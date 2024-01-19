using System.Collections;
using UnityEngine;

public class Coroutines1 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Coroutines1 Awake");
    }
    void OnEnable()
    {
        Debug.Log("Coroutines1 OnEnable");
    }
    void Start()
    {
        Debug.Log("Coroutines1 Start");
        StartCoroutine(Coroutine());
    }
    void Update()
    {
        for (int i = 0; i < 100000000; i++)
        {

        }
        CoroutinesTimePrinter.PrintTime("Coroutines1");

    }
    void FixedUpdate()
    {
        CoroutinesTimePrinter.PrintTime("Coroutines1 FixedUpdate", "orange");
    }
    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return null;
            CoroutinesTimePrinter.PrintTime("Coroutines1 Coroutines", "red");
        }
    }
}