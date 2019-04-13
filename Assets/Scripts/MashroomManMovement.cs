using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashroomManMovement : MonoBehaviour
{
    public float leftPoint = 1.71f;
    public float rightPoint = 23;
    public int direction = 1;

    private void Update()
    {
        if (direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            direction = 1;
        }

        if (this.transform.position.x > rightPoint)
        {
            direction = 2;
        }

        if (direction == 2)
        {
            transform.Translate(Vector3.right * (-2) * Time.deltaTime, Space.World);
            direction = 2;
        }

        if (this.transform.position.x < leftPoint)
        {
            direction = 1;
        }
    }

}
