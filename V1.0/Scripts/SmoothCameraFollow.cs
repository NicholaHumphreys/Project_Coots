using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public float dampening;

    private Vector3 velocity = Vector3.zero;

       // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movePOsition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePOsition, ref velocity, dampening);
    }
}