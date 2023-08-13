using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncludedAngle : MonoBehaviour
{
    public Transform target;
    Vector3 targetDirection;
    float incluedAngle;
    Color targetColor;
    Material targetMat;

    float distance;
    float hypotenuse;
    float oppositeSide;
    void Start()
    {
        targetColor = target.GetComponent<MeshRenderer>().material.color;
        targetMat = target.GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        targetDirection = target.position - transform.position;
        incluedAngle = Vector3.Angle(targetDirection, transform.forward);

        Debug.DrawLine(transform.position, targetDirection.normalized * 100, Color.red);

        Debug.DrawLine(transform.position, transform.forward * 100);

        distance = Vector3.Distance(transform.position, target.position);

        hypotenuse = distance / Mathf.Cos(incluedAngle * Mathf.Deg2Rad);
        oppositeSide = Mathf.Sqrt(Mathf.Pow(hypotenuse, 2) - Mathf.Pow(distance, 2));

        if (incluedAngle < 90 && oppositeSide <= 1)
        {
            targetMat.color = Color.Lerp(targetColor, Color.white, Mathf.PingPong(Time.time, 1));
        }
        else
        {
            targetMat.color = targetColor;
        }
    }

    public int VertexCount = 200;

    void OnDrawGizmos()
    {
        float deltaTheta = 2f * Mathf.PI / VertexCount;
        float theta = 0f;
        Vector3 lastPos = transform.position;
        for (int i = 0; i < VertexCount + 1; i++)
        {
            Vector3 currentPos = new Vector3(distance * Mathf.Cos(theta), 0, distance * Mathf.Sin(theta));
            Gizmos.DrawLine(lastPos, transform.position + currentPos);
            Gizmos.color = Color.red;
            lastPos = transform.position + currentPos;

            theta += deltaTheta;
        }
        Gizmos.color = Color.green;
        Vector3 direction = transform.position - target.position;
        Vector3 crossDirection = Vector3.Cross(target.up, direction);
        Gizmos.DrawRay(target.position, crossDirection * 100);
        Gizmos.DrawRay(target.position, -crossDirection * 100);
    }
}
