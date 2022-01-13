using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Follow the Driver (copy position)
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
        // var position = thingToFollow.transform.position;
        // position.z = -10;
        // transform.position = position;
    }
}
