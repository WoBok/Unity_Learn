using System;
using UnityEngine;

public class CoroutinesTimePrinter
{
    public static void PrintTime(string calssName, string color = "lime")
    {
        //Debug.Log($"<color={color}>{calssName} Update, " +
        //    $"Time.deltaTime: {Time.deltaTime}, " +
        //    $"Time.timeAsDouble: {Time.timeAsDouble}, " +
        //    $"Time.unscaledTimeAsDouble: {Time.unscaledTimeAsDouble}," +
        //    $"Time.realtimeSinceStartupAsDouble: {Time.realtimeSinceStartupAsDouble}," +
        //    $" System time:{DateTime.Now.ToString("O")}" +
        //    $"</color>");
        Debug.Log($"<color={color}>{calssName}, " +
            $"��ǰ֡ʱ�䣺 {Time.unscaledTimeAsDouble}, " +
            $"ϵͳʱ�䣺 {DateTime.Now.ToString("O")}" +
            $"</color>");
    }
}