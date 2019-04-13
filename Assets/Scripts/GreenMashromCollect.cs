using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMashromCollect : MonoBehaviour
{
    public AudioSource LiveUpSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(0, -1000, 0);
            LiveUpSound.Play();
            if (GlobalLives.livesAmount < 3)
                GlobalLives.livesAmount += 1;
        }
    }
}
