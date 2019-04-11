using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform player;
    public float distanceFromPlayer;
    public float staticCameraY;

    void Start()
    {
        distanceFromPlayer = 10;
        staticCameraY = transform.position.y;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, staticCameraY, player.position.z - distanceFromPlayer);
    }
}
