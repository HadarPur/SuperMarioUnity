using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level01_load : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(2);
    }
}
