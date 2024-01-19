using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ2 : MonoBehaviour
{
    void Start()
    {
        int intValue = 55;
        var anonymousType = new { value1 = "Valu1", value2 = 2, value3 = 3.0f, varlue4 = new LINQ2Data().v1 = "ABC", LINQ2Data.v2, intValue };
        print($"{anonymousType.value1}, {anonymousType.value2}, {anonymousType.value3},{anonymousType.varlue4},{anonymousType.v2},{anonymousType.intValue}");
        int[] intValues = { 1, 2, 3, 4, 5 };
        IEnumerable<int> nums = from int n in intValues where n > 0 select n;
        nums.ToArray();
    }
}
public class LINQ2Data
{
    public string v1;
    static public int v2 = 5;
}
