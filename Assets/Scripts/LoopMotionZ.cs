using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://answers.unity.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html

public class LoopMotionZ : MonoBehaviour
{
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        velocity = v - transform.position;
        transform.position = v;
    }
}
