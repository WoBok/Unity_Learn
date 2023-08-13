using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LINQ1 : MonoBehaviour
{
    int[] numbers = { 1, 6, 12, 3, 4, 23, 909, 34 };

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) { A(); }
        if (Input.GetKeyDown(KeyCode.B)) { B(); }
    }
    void A()
    {
        IEnumerable<int> lowNums = from n in numbers where n < 10 select n;
        foreach (var x in lowNums)
        {
            print("lowNums:" + x);
        }
    }
    void B()
    {
        List<LINQ1Data1> l1Data1s = new List<LINQ1Data1>();
        for (int i = 0; i < 10; i++)
        {
            l1Data1s.Add(new LINQ1Data1 { num1 = i * Random.Range(0, 10) });
        }
        List<LINQ1Data1> ldLessThan50 = GetL1D1Nums(l1Data1s);
        if (ldLessThan50 != null)
        {
            foreach (var ld in ldLessThan50)
            {
                print("ldLessThan50:" + ld.num1);
            }
        }
    }
    List<LINQ1Data1> GetL1D1Nums(List<LINQ1Data1> l1Data1s)
    {
        List<LINQ1Data1> lds = new List<LINQ1Data1>();
        IEnumerable<LINQ1Data1> lessThan50 = from ld in l1Data1s where ld.num1 < 50 select ld;
        foreach (var item in lessThan50)
        {
            lds.Add(item);
        }
        return lds;
    }
}
public class LINQ1Data1
{
    public int num1;
    public string str1;
}
