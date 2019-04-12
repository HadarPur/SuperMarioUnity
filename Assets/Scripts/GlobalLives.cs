﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLives : MonoBehaviour
{
    public static int livesAmount = 3;
    public int internalLives;
    public GameObject lifesTextBox;

    private void Update()
    {
        internalLives = livesAmount;
        lifesTextBox.GetComponent<Text>().text = "" + internalLives;

        if (internalLives == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
