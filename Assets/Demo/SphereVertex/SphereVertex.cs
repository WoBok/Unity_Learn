using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=lctXaT9pxA0
public class SphereVertex : MonoBehaviour
{
    public int numHorizontalSegments;
    public float TAU;
    void Start()
    {
        for (int h = 0; h < numHorizontalSegments; h++)
        {
            float angle1 = (h + 1) * Mathf.PI / (numHorizontalSegments + 1);
            for (int v = 0; v < numHorizontalSegments; v++)
            {
                float angle2 = v * TAU / numHorizontalSegments;

                float x = Mathf.Sin(angle1) * Mathf.Cos(angle2);
                float y = Mathf.Cos(angle1);
                float z = Mathf.Sin(angle1) * Mathf.Sin(angle2);

                var gObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gObj.transform.position = new Vector3(x, y, z);
                gObj.transform.localScale = Vector3.one * 0.01f;
                gObj.transform.SetParent(transform, false);
            }
        }
    }

}
