using System;
using UnityEngine;
public class UnityTime : MonoBehaviour
{
    DateTime t;
    void Update()
    {
        Debug.Log($"<color=lime>Time.captureDeltaTime: {Time.captureDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.captureFramerate:{Time.captureFramerate}</color>");
        Debug.Log($"<color=lime>Time.deltaTime: {Time.deltaTime}</color>");
        Debug.Log($"<color=lime>Time.fixedDeltaTime: {Time.fixedDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.fixedTime: {Time.fixedTime}</color>");
        Debug.Log($"<color=lime>Time.fixedTimeAsDouble: {Time.fixedTimeAsDouble}</color>");
        Debug.Log($"<color=lime>Time.fixedUnscaledDeltaTime: {Time.fixedUnscaledDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.fixedUnscaledTime: {Time.fixedUnscaledTime}</color>");
        Debug.Log($"<color=lime>Time.fixedUnscaledTimeAsDouble: {Time.fixedUnscaledTimeAsDouble}</color>");
        Debug.Log($"<color=lime>Time.frameCount: {Time.frameCount}</color>");
        Debug.Log($"<color=lime>Time.inFixedTimeStep: {Time.inFixedTimeStep}</color>");
        Debug.Log($"<color=lime>Time.maximumDeltaTime: {Time.maximumDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.maximumParticleDeltaTime: {Time.maximumParticleDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.realtimeSinceStartup: {Time.realtimeSinceStartup}</color>");
        Debug.Log($"<color=lime>Time.realtimeSinceStartupAsDouble: {Time.realtimeSinceStartupAsDouble}</color>");
        Debug.Log($"<color=lime>smoothDeltaTime: {Time.smoothDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.time: {Time.time}</color>");
        Debug.Log($"<color=lime>Time.timeAsDouble: {Time.timeAsDouble}</color>");
        Debug.Log($"<color=lime>Time.timeScale: {Time.timeScale}</color>");
        Debug.Log($"<color=lime>Time.timeSinceLevelLoad: {Time.timeSinceLevelLoad}</color>");
        Debug.Log($"<color=lime>Time.timeSinceLevelLoadAsDouble: {Time.timeSinceLevelLoadAsDouble}</color>");
        Debug.Log($"<color=lime>Time.unscaledDeltaTime: {Time.unscaledDeltaTime}</color>");
        Debug.Log($"<color=lime>Time.unscaledTime: {Time.unscaledTime}</color>");
        Debug.Log($"<color=lime>Time.unscaledTimeAsDouble: {Time.unscaledTimeAsDouble}</color>");
        var s = DateTime.Now - t;
        Debug.Log($"TimeSpan Seconds{s.Seconds}");
        Debug.Log($"TimeSpan TotalSeconds{s.TotalSeconds}");
        Debug.Log("<color=red>---------------------------------------------------------------------------------</color>");
        t = DateTime.Now;
    }
}