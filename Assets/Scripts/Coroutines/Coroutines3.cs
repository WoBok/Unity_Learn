using System.Collections;
using UnityEngine;

public class Coroutines3 : MonoBehaviour
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
        CoroutinesTimePrinter.PrintTime("Coroutines3");
    }
    void FixedUpdate()
    {
        CoroutinesTimePrinter.PrintTime("Coroutines3 FixedUpdate", "orange");
    }
    IEnumerator Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            CoroutinesTimePrinter.PrintTime("Coroutines3 WaitForSeconds", "cyan");
        }
    }
}