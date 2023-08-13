using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using UnityEngine;

public class DownloadString : MonoBehaviour
{
    Stopwatch sw = new Stopwatch();
    void Start()
    {
        DoRun();
    }
    int CountCharacters(int id, string uiString)
    {
        WebClient webClient = new WebClient();
        print($"Starting call {id}: {sw.Elapsed.TotalMilliseconds,4:NO}ms");
        string result = webClient.DownloadString(new Uri(uiString));
        print($"Call {id} completed: {sw.Elapsed.TotalMilliseconds,4:NO}ms");
        return result.Length;
    }
    void CountToALargeNubmer(int id, int value)
    {
        for (long i = 0; i < value; i++)
        {
            print($"End counting {id}: {sw.Elapsed.TotalMilliseconds,4:NO}ms");
        }
    }
    void DoRun()
    {
        const int LN = 6_000_000;
        sw.Start();
        int t1 = CountCharacters(1, "http://www.baidu.com");
        int t2 = CountCharacters(2, "http://www.bilibili.com");
        CountToALargeNubmer(1, LN);
        CountToALargeNubmer(2, LN);
        CountToALargeNubmer(3, LN);
        CountToALargeNubmer(4, LN);
        print($"Char in http://www.microsoft.com : {t1}");
        print($"Char in http://www.illustratedcsharp.com :{t2}");

    }
}
