using UnityEngine;

public class UIIsVisiableInCamera : MonoBehaviour
{
    Camera cam;
    Bounds bounds;
    Plane[] planes;
    void Start()
    {
        bounds = new Bounds();
        cam = Camera.main;
        var rect = GetComponent<RectTransform>();
        if (rect != null)
        {
            var corners = new Vector3[4];
            rect.GetWorldCorners(corners);
            var boundsSize = corners[2] - corners[0];
            bounds.size = new Vector3(boundsSize.x, boundsSize.y, 0.1f);
            Debug.Log("bounds.size: " + bounds.size);
        }
    }

    void Update()
    {
        bounds.center = transform.position;
        planes = GeometryUtility.CalculateFrustumPlanes(cam);
        if (GeometryUtility.TestPlanesAABB(planes, bounds))
        {
            Debug.Log(name + " has been detected!");
        }
        else
        {
            Debug.Log("Nothing has been detected");
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawCube(bounds.center, bounds.size);
    }
}