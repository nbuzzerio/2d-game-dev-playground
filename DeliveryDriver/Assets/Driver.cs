using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    float turnSpeed = 0.1f;
    float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
        transform.Translate(moveSpeed, moveSpeed, 0);
        
    }
}
