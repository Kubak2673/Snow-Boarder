using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Dodajemy, aby używać UI

public class GameManager : MonoBehaviour
{
    public int totalItems = 8; // Liczba przedmiotów do zebrania
    private int collectedItems = 0; // Aktualnie zebrane przedmioty
    
    public Text collectedItemsText; // Referencja do komponentu Text UI

    void Start()
    {
        // Na starcie ustawiamy tekst informujący o zebranych przedmiotach
        UpdateCollectedItemsText();
    }

    // Metoda wywoływana po zebraniu przedmiotu
    public void CollectItem()
    {
        collectedItems++; // Zwiększ licznik zebranych przedmiotów
        Debug.Log("Zebrano przedmiot! Zebrano: " + collectedItems + "/" + totalItems);
        
        // Aktualizujemy tekst w interfejsie
        UpdateCollectedItemsText();
        
        // Sprawdź, czy gracz zebrał wszystkie przedmioty
        if (collectedItems >= totalItems)
        {
            Debug.Log("Zebrano wszystkie przedmioty! Przechodzisz na kolejną mapę.");
            LoadNextLevel(); // Przejdź na nowy poziom
        }
    }

    // Aktualizacja tekstu na ekranie
    void UpdateCollectedItemsText()
    {
        collectedItemsText.text = "Zebrano: " + collectedItems + "/" + totalItems;
    }

    // Przejście na nową mapę
    void LoadNextLevel()
    {
        // Ładowanie kolejnej sceny - upewnij się, że dodałeś kolejne mapy w Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}



