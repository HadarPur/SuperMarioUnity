using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBlock001 : MonoBehaviour
{
    public GameObject deadBlock;
    public GameObject qBlock;
    public GameObject mashroom;
    public bool mashroomOut = false;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (!mashroomOut)
        {
            mashroomOut = true;
            qBlock.SetActive(false);
            deadBlock.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            mashroom.SetActive(true);
      }
    }
}
