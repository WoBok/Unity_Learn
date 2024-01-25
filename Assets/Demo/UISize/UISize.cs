using UnityEngine;

public class UISize : MonoBehaviour
{
    void Start()
    {
        var rect = GetComponent<RectTransform>();
        Debug.Log(rect.rect);
        Debug.Log(rect.rect.size);
        var corners = new Vector3[4];
        rect.GetWorldCorners(corners);
        for (int i = 0; i < corners.Length; i++)
        {
            Debug.Log(corners[i]);
        };
    }
}