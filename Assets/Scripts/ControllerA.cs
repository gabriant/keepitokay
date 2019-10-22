﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerA : MonoBehaviour
{
    public float smooth = 5.0f;
    public float tiltAngle = 60.0f;

    void Update ()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * -tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.adad
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(
            transform.rotation, target, Time.deltaTime * smooth
        );

    }
}