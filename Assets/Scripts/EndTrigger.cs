using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;


    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
        Debug.Log("OnTriggerEnter");
    }

    void OnTriggerExit()
    {
        gameManager.CompleteLevel();
        Debug.Log("OnTriggerExit");
    }

}

