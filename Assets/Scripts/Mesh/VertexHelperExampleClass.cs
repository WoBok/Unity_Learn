using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VertexHelperExampleClass : MonoBehaviour
{
    void Start()
    {
        Mesh m = new Mesh();
        Color32 color32 = Color.green;
        using (VertexHelper vh = new VertexHelper())
        {
            vh.AddVert(new Vector3(0, 0), color32, new Vector2(0f, 0f));
            vh.AddVert(new Vector3(0, 100), color32, new Vector2(0f, 1f));
            vh.AddVert(new Vector3(100, 100), color32, new Vector2(1f, 1f));
            vh.AddVert(new Vector3(100, 0), color32, new Vector2(1f, 0f));

            vh.AddTriangle(0, 1, 2);
            vh.AddTriangle(2, 3, 0);
            vh.FillMesh(m);
        }
    }
}
