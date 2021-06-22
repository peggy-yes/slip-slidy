using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void YouDied ()
    {
        youDiedUI.SetActive(true);
    }

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public GameObject youDiedUI;

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartDelay = 1f;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            YouDied();
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

