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
            $"当前帧时间： {Time.unscaledTimeAsDouble}, " +
            $"系统时间： {DateTime.Now.ToString("O")}" +
            $"</color>");
    }
}