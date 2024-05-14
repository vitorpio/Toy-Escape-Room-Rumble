using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearController : MonoBehaviour
{
    private Transform transform;
    private int rotationPerFrame = 1;

    void Awake()
    {
        transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, rotationPerFrame, 0));
    }
}
