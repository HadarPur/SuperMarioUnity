using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expScript : MonoBehaviour
{
    public GameObject remain;
    public AudioSource crackingEffect;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (other.transform.position.y - gameObject.transform.position.y < 0) && (other.transform.localScale.x > 1))
        {
            crackingEffect.Play();
            GlobalScore.currenScore += 5;
            Instantiate(remain, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
