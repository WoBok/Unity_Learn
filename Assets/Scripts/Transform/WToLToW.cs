using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WToLToW : MonoBehaviour
{
    void Start()
    {
        //Parent Position:(2,3,7)
        //Child Position:(0,2,5)
        Vector3 lToW = transform.TransformPoint(transform.GetChild(0).transform.localPosition);
        print(lToW);//(2,5,12)
        Vector3 wToL = transform.InverseTransformPoint(lToW);
        print(wToL);//(0,2,5)
        print("--------------------------------------------------------");
        //GameObject Position:(2,3,7)
        Vector3 pos = new Vector3(2, 5, 8);
        print(transform.TransformPoint(pos));//(4,8,15)//pos看作Local Position L→W，Local Position+GameObejct Position
        print(transform.InverseTransformPoint(pos));//(0,2,1)//pos看作World Position W→L，World Position-GameObject Position
        Vector3 pos2 = new Vector3(-2, 8, -11);
        print(transform.TransformPoint(pos2));//(0,11,-4)
        print(transform.InverseTransformPoint(pos2));//(-4,5,-18)
    }
}
