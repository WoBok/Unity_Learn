using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LINQ3 : MonoBehaviour
{
    void Start()
    {
        Func<int, bool> func = IsOdd;
    }
    bool IsOdd(int x)
    {
        return x % 2 == 0;
    }
    public int Count(int[] arr, Func<int, bool> func)
    {
        int x = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var isOdd = func(arr[i]);
            if (isOdd)
            {
                x++;
            }
        }
        return x;
    }
}
