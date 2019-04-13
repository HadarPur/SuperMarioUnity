using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountingDown : MonoBehaviour
{

    public int TotalTime = 301;
    public GameObject TimeDisplay;
    public int CalculatingTime;
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CamFollow;
    public GameObject ThePlayer;
    public int KeepZero;
    public static int TimeLeft;


    private void Update()
    {
        TimeLeft = TotalTime;
        if (KeepZero == 0)
        {
            TimeDisplay.GetComponent<Text>().text = "" + TotalTime;
        }

        if (CalculatingTime == 0)
        {
            StartCoroutine(DeductTime());
        }

        if (TotalTime == 0)
        {
            StartCoroutine(TimeUp());
        }
    }

    

    private IEnumerator DeductTime()
    {
        CalculatingTime = 1;
        TotalTime -= 1;
        yield return new WaitForSeconds(1);
        CalculatingTime = 0;
    }

    private IEnumerator TimeUp()
    {
        TotalTime -= 1;
        KeepZero = 1;
        TimeDisplay.GetComponent<Text>().text = "0";
        GlobalLives.livesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        CamFollow.GetComponent<CameraFollowScript>().enabled = false;
        ThePlayer.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;
        ThePlayer.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false;
        ThePlayer.transform.position += new Vector3(0, 2, 0);
        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;
        yield return new WaitForSeconds(3);
        GlobalScore.currenScore = 0;
        SceneManager.LoadScene(3);
    }
}
