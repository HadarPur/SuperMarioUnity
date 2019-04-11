using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expScript : MonoBehaviour
{
    public GameObject remain;
    public AudioSource crackingEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && transform.position.x > other.gameObject.GetComponent<Transform>().position.x)
        {
            crackingEffect.Play();
            Instantiate(remain, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
