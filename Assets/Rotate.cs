using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeedX = 69.69f;
    public float rotateSpeedY = 69.69f;
    public float rotateSpeedZ = 69.69f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.GetComponent<Transform>();
        //(1,1,1) == Vector3.one
        transform.Rotate(new Vector3(rotateSpeedX, rotateSpeedY, rotateSpeedZ));
    }
}
