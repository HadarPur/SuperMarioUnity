using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI; using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{     public Canvas quitMenu;     public Button playText;     public Button exitText;       // Start is called before the first frame update     void Start()     {
        quitMenu.enabled = false;     }      public void exitPress()     {         quitMenu.enabled = true;         playText.enabled = false;         exitText.enabled = false;     }      public void noPress()     {         quitMenu.enabled = false;         playText.enabled = true;         exitText.enabled = true;     }      public void startLevel()     {
        GlobalLives.livesAmount = 3;         GlobalCoins.coinsCount = 0;
        GlobalScore.currenScore = 0;         SceneManager.LoadScene(1);     }      public void exitMenu()     {         Application.Quit();     }
}
