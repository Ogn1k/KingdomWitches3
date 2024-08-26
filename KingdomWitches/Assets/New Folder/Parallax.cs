using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Transform followingTarget;
    [SerializeField, Range(0f, 1f)] float parallaxStrength = 1.0f;
    [SerializeField] bool disableVerticalParallax;
    Vector3 targetPreviousPosition;
    void Start()
    {
        if (!followingTarget)
            followingTarget = Camera.main.transform ;
        targetPreviousPosition = followingTarget.position - new Vector3(0, 2f, 0);
    }
    void Update()
    {
        var delta = (followingTarget.position - new Vector3(0, 2f, 0)) - targetPreviousPosition;
        if (disableVerticalParallax)
        {
            delta.y = 0;
        }
        targetPreviousPosition = followingTarget.position - new Vector3(0, 2f, 0);

        transform.position += delta * parallaxStrength;
    }
}
