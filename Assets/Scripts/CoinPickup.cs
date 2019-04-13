using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioSource coinsEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinsEffect.Play();
            GlobalCoins.coinsCount += 1;
            GlobalScore.currenScore += 10;
        }
    }
}
