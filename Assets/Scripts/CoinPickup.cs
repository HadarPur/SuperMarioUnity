using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioSource coinsEffect;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        coinsEffect.Play();
        GlobalCoins.coinsCount += 1;
    }
}
