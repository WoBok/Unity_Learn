using UnityEngine;
//https://docs.unity.cn/cn/current/ScriptReference/GeometryUtility.TestPlanesAABB.html
public class IsVisiableInCamera : MonoBehaviour
{

    public GameObject obj;
    Collider objCollider;

    Camera cam;
    Plane[] planes;

    void Start()
    {
        cam = Camera.main;
        objCollider = obj.GetComponent<Collider>();
    }

    void Update()
    {
        planes = GeometryUtility.CalculateFrustumPlanes(cam);

        if (GeometryUtility.TestPlanesAABB(planes, objCollider.bounds))
        {
            Debug.Log(obj.name + " has been detected!");
        }
        else
        {
            Debug.Log("Nothing has been detected");
        }
    }
}
