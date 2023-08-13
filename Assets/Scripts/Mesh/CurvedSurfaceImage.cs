using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurvedSurfaceImage : Image
{
    [SerializeField]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        vh.AddVert(new Vector3(), color, new Vector2());
        vh.AddVert(new Vector3(0, 100), color, new Vector2(0, 1));
        vh.AddVert(new Vector3(100, 100), color, new Vector2(1, 1));

        vh.AddTriangle(0, 1, 2);



    }
}
