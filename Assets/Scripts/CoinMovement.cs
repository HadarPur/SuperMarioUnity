using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public GameObject actualCoin;
    public GameObject thisCoin;

    private void Update()
    {
        transform.parent = null;
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        StartCoroutine(CloseAnim());
    }

    private IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.4f);
        thisCoin.SetActive(false);
        actualCoin.SetActive(true);
    }
}
