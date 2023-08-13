using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ForeachListAddElement : MonoBehaviour
{
    List<int> nums = new List<int>();
    int n = 11;
    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            nums.Add(i);
        }
        for (int i = 1; i <= 2; i++)
        {
            map.Add(i, new List<int>());
            for (int j = 1; j <= 5; j++)
            {
                map[i].Add(j);
            }
        }
    }
    private void OnGUI()
    {
        if (GUILayout.Button("开始输出列表"))
        {
            StartCoroutine("PrintNums");
        }
        if (GUILayout.Button("添加数字"))
        {
            nums.Add(n);
            n++;
        }
        if (GUILayout.Button("PrintMapNums"))
        {
            StartCoroutine("PrintMapNums");
        }
        if (GUILayout.Button("添加数字"))
        {
            map.Add(n, new List<int>());
            map[n].Add(n);
            n++;
        }
    }
    IEnumerator PrintNums()
    {
        while (true)
        {
            print(nums[0]);
            nums.RemoveAt(0);
            yield return new WaitForSeconds(1);
            if (nums.Count == 0)
                yield break;
        }
    }
    IEnumerator PrintMapNums()
    {
        while (true)
        {
            if (CheckIfTheMessageIsEmpty())
                yield break;
            for (int i = 0; i < map.Count; i++)
            {
                var m = map.ElementAt(i);
                while (true)
                {
                    if (m.Value.Count <= 0)
                        break;
                    print(m.Value[0]);
                    m.Value.RemoveAt(0);
                    yield return new WaitForSeconds(1);
                }
            }
        }
    }
    bool CheckIfTheMessageIsEmpty()
    {
        foreach (var m in map.Values)
        {
            if (m.Count > 0)
                return false;
        }
        return true;
    }
}
