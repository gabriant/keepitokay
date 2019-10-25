﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class ControllerA : MonoBehaviour
{
    [Slider(0f, 100f)]
    public float smooth = 5.0f;

    [Slider(15f, 90f)]
    public int maxAngle = 60;

    [ShowNonSerializedField]
    private float tiltAroundZ;

    void Update ()
    {
        tiltAroundZ = Input.GetAxis("Horizontal") * maxAngle;
    }

    void FixedUpdate ()
    {
        Quaternion target = Quaternion.Euler(0, 0, -tiltAroundZ);

        transform.rotation = Quaternion.Slerp(
            transform.rotation, target, Time.fixedDeltaTime * smooth
        );
    }
}
