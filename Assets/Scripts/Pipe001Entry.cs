using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Entry : MonoBehaviour
{
    public GameObject pipe_entry;
    public int StoodOn;

    public GameObject mainCam;
    public GameObject secCam;
    public GameObject mainPlayer;

    public GameObject fadeScreen;
    public AudioSource pipeEffect;
    public AudioSource pipeEffectOut;

    private void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    private void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("GoDown"))
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(playAnim());
            }
        }
    }

    IEnumerator playAnim()
    {
        pipeEffect.Play();
        fadeScreen.SetActive(true);
        pipe_entry.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1.5f);  
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        pipe_entry.GetComponent<Animator>().enabled = false;
        secCam.SetActive(true);
        mainCam.SetActive(false);
        mainPlayer.transform.position = new Vector3(64, -5, -43);
        pipe_entry.GetComponent<Animator>().enabled = true;
        pipeEffectOut.Play();
        yield return new WaitForSeconds(0.495f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        fadeScreen.SetActive(false);

    }

}
