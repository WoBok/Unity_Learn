using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{

    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;

    float smothTime = 1f;
    float xVelocity = 0;
    float targetX = 5;
    float newX = 0;

    Vector3 targetPos = new Vector3(5, 0, 2);
    Vector3 targetPos2 = new Vector3(5, 0, 4);

    private void Start()
    {
        float a = 5;
        float b = 0;
        for (int i = 0; i < 5; i++)
        {
            b += a * 0.125f;
            a = a - a * 0.125f;
            print("b:" + b + "," + "a:" + a);
        }
    }
    void Update()
    {
        //newX = Mathf.SmoothDamp(gameObject1.transform.position.x, targetX, ref xVelocity, smothTime);
        //gameObject1.transform.position = new Vector3(newX, gameObject1.transform.position.y, gameObject1.transform.position.z);

        //gameObject2.transform.position = Vector3.Lerp(gameObject2.transform.position, targetPos, 0.5f * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(Move());
        }


    }

    IEnumerator Move()
    {
        while (true)
        {
            newX = Mathf.SmoothDamp(gameObject1.transform.position.x, targetX, ref xVelocity, smothTime);
            gameObject1.transform.position = new Vector3(newX, gameObject1.transform.position.y, gameObject1.transform.position.z);

            gameObject2.transform.position = Vector3.Lerp(gameObject2.transform.position, targetPos, 0.5f / 4);
            gameObject3.transform.position = Vector3.Lerp(gameObject3.transform.position, targetPos2, 0.5f);
            yield return new WaitForSeconds(1);
        }
    }

}
