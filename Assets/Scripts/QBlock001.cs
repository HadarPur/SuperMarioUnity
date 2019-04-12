using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBlock001 : MonoBehaviour
{
    public GameObject deadBlock;
    public GameObject qBlock;
    public GameObject mashroom;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        qBlock.SetActive(false);
        deadBlock.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        mashroom.SetActive(true);
    }
}
