using UnityEngine;

public class Coroutines5 : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Coroutines5 Awake");
    }
    void OnEnable()
    {
        Debug.Log("Coroutines5 OnEnable");
    }
    void Start()
    {
        Debug.Log("Coroutines5 Start");
    }
    void Update()
    {
        for (int i = 0; i < 100000000; i++)
        {

        }
        CoroutinesTimePrinter.PrintTime("Coroutines5");
    }
    void FixedUpdate()
    {
        CoroutinesTimePrinter.PrintTime("Coroutines5 FixedUpdate", "orange");
    }
}