using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingPlayer : MonoBehaviour
{
    public Transform cameraTarget; //camera that chooses targeting the object
    public float speed = 10.0f; // carema following speed
    public Vector3 dist; // camera to player distance
    public Transform lookTarget; // Targei object that camera makes move to position which is positioned on.

    void FixedUpdate() {
        Vector3 dPos = cameraTarget.position + dist; // To make move camera following object.
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, speed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }

}
