using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false; // Czy gra jest wstrzymana
    public GameObject pauseMenuUI; // Referencja do panelu pauzy

    void Update()
    {
        // Sprawdza, czy naciśnięto klawisz Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume(); // Wznowienie gry
            }
            else
            {
                Pause(); // Pauza
            }
        }
    }

    // Funkcja do wznawiania gry
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Ukrywa menu pauzy
        Time.timeScale = 1f; // Wznawia normalny bieg czasu
        isPaused = false;
    }

    // Funkcja do pauzowania gry
    void Pause()
    {
        pauseMenuUI.SetActive(true); // Wyświetla menu pauzy
        Time.timeScale = 0f; // Zatrzymuje czas w grze
        isPaused = true;
    }

    // Funkcja do powrotu do głównego menu
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Przywraca normalny czas przed wyjściem
        SceneManager.LoadScene("MainMenu"); // Załaduj scenę głównego menu
    }

    // Funkcja do wyjścia z gry
    public void QuitGame()
    {
        Application.Quit(); // Zamknij aplikację
    }
}

