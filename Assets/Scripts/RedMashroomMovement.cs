using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedMashroomMovement : MonoBehaviour
{
    public GameObject actualMashroom;
    public GameObject thisMashroom;

    private void Update()
    {
        transform.parent = null;
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        CloseAnim();
    }

    private IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.4f);
        thisMashroom.SetActive(false);
        actualMashroom.SetActive(true);
    }
}
