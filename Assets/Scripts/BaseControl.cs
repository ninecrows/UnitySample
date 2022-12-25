using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BaseControl : MonoBehaviour
{
    public float velocity = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        if (velocity < 0.0001f)
        {
            velocity = 1.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float timeTick = Time.deltaTime;

        float deltaX = Input.GetAxis("Horizontal");
        float deltaY = Input.GetAxis("Vertical");

        transform.Translate(deltaX * timeTick * velocity, 0, deltaY * timeTick * velocity);
    }
}
