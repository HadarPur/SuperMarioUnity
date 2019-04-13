using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public static int currenScore;
    public int internalScore;
    public GameObject scoreDisplay;

    private void Update()
    {
        internalScore = currenScore;
        scoreDisplay.GetComponent<Text>().text = "" + internalScore;
    }
}
