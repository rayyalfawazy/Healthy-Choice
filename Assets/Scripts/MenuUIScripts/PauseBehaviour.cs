using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PauseBehaviour : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject pausePanel;
    public HideCursor cursorHider;

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

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        cursorHider.MakeVisibleUnlocked();
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        cursorHider.MakeInvisibleLocked();
    }
}

