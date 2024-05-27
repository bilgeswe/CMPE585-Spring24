using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target; // The target to follow
    public float distance = 5f; // Distance from the target
    public float smoothSpeed = 0.125f; // Smoothing speed

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("No target specified for camera follow!");
            return;
        }

        Vector3 desiredPosition = target.position - transform.forward * distance;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}