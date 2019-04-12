using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01Death : MonoBehaviour
{
    public AudioSource DeathSound;
    public GameObject LevelMusic;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        GlobalLives.livesAmount -= 1;
        LevelMusic.SetActive(false);
        DeathSound.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
