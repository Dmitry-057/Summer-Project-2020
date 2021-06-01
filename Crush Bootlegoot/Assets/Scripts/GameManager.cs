using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    
    
    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    public void CompletedGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("You won!");
            Restart();
        }

    }

    void Restart ()
    {
        FindObjectOfType<AudioManager>().Stop("LevelTheme");
        FindObjectOfType<AudioManager>().Play("MenuTheme");
        SceneManager.LoadScene("MainMenu");
    }
}
