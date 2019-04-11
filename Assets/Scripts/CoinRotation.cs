using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.World);
    }
}
