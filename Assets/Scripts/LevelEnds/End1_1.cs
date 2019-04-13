using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End1_1 : MonoBehaviour
{
    public GameObject fadeScreen;
    public GameObject thePlayer;
    public int timeScore;
    public int timeLeft;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        fadeScreen.SetActive(true);
        fadeScreen.GetComponent<Animator>().enabled = true;
        timeLeft = CountingDown.TimeLeft;
        timeScore = timeLeft * 10;
        GlobalScore.currenScore += timeScore;
        yield return new WaitForSeconds(0.495f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        // back to the menu screen
        SceneManager.LoadScene(0);
    }
}
