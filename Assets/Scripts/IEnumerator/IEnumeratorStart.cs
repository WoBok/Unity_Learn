using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IEnumeratorStart : MonoBehaviour
{
    public List<int> nums = new List<int>();
    Coroutine currentCoroutine;
    void OnGUI()
    {
        if (GUILayout.Button("开启携程A1"))
        {
            StartCoroutine(A(1));
        }
        if (GUILayout.Button("开启携程A2"))
        {
            StartCoroutine(A(2));
        }
        if (GUILayout.Button("开启携程B1"))
        {
            StartCoroutine("B");
        }
        if (GUILayout.Button("开启携程B2"))
        {
            StartCoroutine(B());
        }
        if (GUILayout.Button("添加10个数据"))
        {
            for (int i = 1; i <= 10; i++)
            {
                nums.Add(i);
            }
        }
        if (GUILayout.Button("添加数据100"))
        {
            nums.Add(100);
        }
        if (GUILayout.Button("输出列表mark:1"))
        {
            if (currentCoroutine == null)
                currentCoroutine = StartCoroutine(C(1));
        }
        if (GUILayout.Button("输出列表mark:2"))
        {
            if (currentCoroutine == null)
                currentCoroutine = StartCoroutine(C(2));
        }
    }
    IEnumerator A(int i)
    {
        print("B");
        while (true)
        {
            print($"<color=lime>{i}</color>");
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator B()
    {
        while (true)
        {
            print("<color=lime>B</color>");
            yield return new WaitForSeconds(2);
        }
    }
    IEnumerator C(int mark)
    {
        while (true)
        {
            if (nums.Count > 0)
            {
                var num = nums[0];
                print(num + ",mark:" + mark);
                nums.RemoveAt(0);
                yield return new WaitForSeconds(1);
            }
            else
            {
                currentCoroutine = null;
                yield break;
            }
        }
    }
}
