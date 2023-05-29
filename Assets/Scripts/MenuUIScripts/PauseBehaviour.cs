using UnityEngine;

public class PauseBehaviour : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject pausePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("Paused");
        pausePanel.SetActive(true);
    }

    private void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Unpaused");
        pausePanel.SetActive(false);
    }
}

