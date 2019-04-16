using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MashroomManDeath : MonoBehaviour
{
    public GameObject mashroomMan;
    public static bool isCrashed = false;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        isCrashed = true;
        this.GetComponent<BoxCollider>().enabled = false;
        mashroomMan.GetComponent<MashroomManMovement>().enabled = false;
        mashroomMan.transform.localScale -= new Vector3(0, 0, 0.4f);
        mashroomMan.transform.localPosition -= new Vector3(0, 0, 0.2f);
        GlobalScore.currenScore += 100;
        yield return new WaitForSeconds(1);
        Destroy(mashroomMan);
    }
}
