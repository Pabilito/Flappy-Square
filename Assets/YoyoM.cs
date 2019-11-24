using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoyoM : MonoBehaviour
{
    public float speed = 10;
    public float deltaTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = GetComponent<Transform>().position;
        currentPos.y += speed;
        GetComponent<Transform>().position = currentPos;
    }

    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(deltaTime);
            speed *= -1;
        }
    }

}

