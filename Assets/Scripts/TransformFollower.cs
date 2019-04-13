using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFollower : MonoBehaviour
{
    public Transform target;
    float x = 0.0f;
    float y = 0.0f;
    public float walkDistance;
    public bool camButtonDown;
    public float runDistance;
    public float height;
    public float xSpeed = 250.0f;
    public float ySpeed = 120.0f;

    // Use this for initialization
    void Start()
    {
        var player = GameObject.FindWithTag("Player");
        target = player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {  //Use the Input Manager to make this user selectable button
            camButtonDown = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            camButtonDown = false;
        }
    }

    void LateUpdate()
    {
        if (camButtonDown)
        {
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            target.rotation = rotation;
        }

        else
        {
            target.position = new Vector3(target.position.x, target.position.y + height, target.position.z - walkDistance);
            target.LookAt(target);
            x = 0;
            y = 0;
        }
    }
}
