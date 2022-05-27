using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public Transform target;

    public float cameraSpeed;
    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(target.position.x, target.position.y + 2f, -10f), cameraSpeed);
    }
}
