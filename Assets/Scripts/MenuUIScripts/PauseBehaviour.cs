using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

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
        Time.timeScale = 0f; // Menghentikan waktu di dalam game (paused)
        // Tambahkan kode tambahan di sini, seperti menampilkan UI pause atau mengatur suara
    }

    private void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Melanjutkan waktu di dalam game (resume)
        // Tambahkan kode tambahan di sini, seperti menyembunyikan UI pause atau mengatur suara
    }
}

