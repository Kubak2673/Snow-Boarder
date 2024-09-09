using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameManager gameManager;

    // Szukamy GameManagera przy uruchomieniu
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); // Znajduje obiekt GameManager na scenie
    }

    // Kiedy gracz wejdzie w kontakt z przedmiotem
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") // Sprawdza, czy to gracz
        {
            gameManager.CollectItem(); // Informujemy GameManager o zebraniu przedmiotu
            Destroy(gameObject); // Usuwamy przedmiot
        }
    }
}

