using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashroomManDeath : MonoBehaviour
{
    public GameObject mashroomMan;
    public int num;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        num = 1;
        this.GetComponent<BoxCollider>().enabled = false;
        mashroomMan.GetComponent<MashroomManMovement>().enabled = false;
        mashroomMan.transform.localScale -= new Vector3(0, 0, 0.4f);
        mashroomMan.transform.localPosition -= new Vector3(0, 0, 0.2f);
        yield return new WaitForSeconds(1);
        Destroy(mashroomMan);
    }
}
