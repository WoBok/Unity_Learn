using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CToP : MonoBehaviour
{
    void Start()
    {
        Vector3 cXb = Vector3.right * Mathf.Cos(-45 * Mathf.Deg2Rad);
        Vector3 cYb = Vector3.up;
        Vector3 cZb = Vector3.forward * Mathf.Sin(-45 * Mathf.Deg2Rad);
        Matrix4x4 cTop = new Matrix4x4();
        cTop.SetColumn(0, cXb);
        cTop.SetColumn(1, cYb);
        cTop.SetColumn(2, cZb);
        cTop.SetColumn(3, new Vector4(1, 1, 0, 1));
        Vector3 localPos = new Vector3(1, 1, 0);
        Vector3 toPpos = cTop * localPos;
        transform.position = toPpos;
    }

}
