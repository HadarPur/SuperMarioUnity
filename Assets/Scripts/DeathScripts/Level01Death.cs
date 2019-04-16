using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01Death : MonoBehaviour
{
    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject camFollow;
    public GameObject thePlayer;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && MashroomManDeath.isCrashed == false)
        {
            if (other.transform.localScale.x < 1)
            {
                GlobalLives.livesAmount -= 1;
                LevelMusic.SetActive(false);
                DeathSound.Play();
                camFollow.GetComponent<CameraFollowScript>().enabled = false;
                thePlayer.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().enabled = false;
                thePlayer.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>().enabled = false;
                thePlayer.transform.position += new Vector3(0, 2, 0);
                thePlayer.GetComponent<CapsuleCollider>().enabled = false;
                yield return new WaitForSeconds(3);
                GlobalScore.currenScore = 0;
                GlobalCoins.coinsCount = 0;
                SceneManager.LoadScene(1);
            }
            else
            {
                other.transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);
                other.transform.Translate(new Vector3(-5, 0.5f, 0.5f));
            }
        }
    }
}
