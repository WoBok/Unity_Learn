using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comparable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public T Max<T>(T a, T b) where T : IComparer<T>
    {
        //return a.Compare(b) > 0 ? a : b; 
    }
}
