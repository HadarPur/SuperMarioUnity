using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBlock002 : MonoBehaviour
{
    public GameObject deadBlock;
    public GameObject qBlock;
    public GameObject coin;
    public bool coinOut = false;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (!coinOut)
        {
            coinOut = true;
            qBlock.SetActive(false);
            deadBlock.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            coin.SetActive(true);
        }
    }
}
