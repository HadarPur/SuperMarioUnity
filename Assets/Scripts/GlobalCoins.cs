using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public GameObject coinDisplay;
    public static int coinsCount;
    public int internalCoin;

    // Update is called once per frame
    void Update()
    {
        internalCoin = coinsCount;
        coinDisplay.GetComponent<Text>().text = "Coins: " + coinsCount;
    }
}
