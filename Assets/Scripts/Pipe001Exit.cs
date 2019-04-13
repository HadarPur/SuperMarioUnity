using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Exit : MonoBehaviour
{
    public AudioSource pipeEffect;
    public AudioSource pipeEffectOut;

    public GameObject fadeScreen;
    public GameObject mainCam;
    public GameObject secCam;
    public GameObject pipeEntry;
    public GameObject mainPlayer;
    public GameObject hollPipe;

    private IEnumerator OnTriggerEnter(Collider other)
    {

        pipeEffect.Play();
        fadeScreen.SetActive(true);

        hollPipe.GetComponent<Collider>().enabled = false;

        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        mainCam.SetActive(true);
        secCam.SetActive(false);
        mainPlayer.transform.position = new Vector3(30, 0.6f, -8);
        pipeEntry.GetComponent<Animator>().enabled = true;
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        pipeEffectOut.Play();
        yield return new WaitForSeconds(1);
        pipeEntry.GetComponent<Animator>().enabled = false;
        fadeScreen.SetActive(false);
    }
}
