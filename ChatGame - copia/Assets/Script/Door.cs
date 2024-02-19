using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorObject; // Referencia al objeto de la puerta
    public KeyPickup keyScript; // Referencia al script de la llave
    public string missingKeyMessage = "¡Falta la llave para abrir esta puerta!"; // Mensaje a mostrar si falta la llave

    // Método que se llama cuando el jugador interactúa con la puerta
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el jugador colisiona con la puerta y tiene la llave
        if (collision.gameObject.CompareTag("Player")  && keyScript.hasKey)
        {
            OpenDoor();
        }
        // Si el jugador colisiona con la puerta pero no tiene la llave, muestra un mensaje
        else if (collision.gameObject.CompareTag("Player")  && !keyScript.hasKey)
        {
            Debug.Log(missingKeyMessage);
        }
    }

    // Método para abrir la puerta
    void OpenDoor()
    {
        //doorObject.SetActive(false);
        Destroy(doorObject); // Destruye el objeto de la puerta
        Debug.Log("¡Puerta abierta!"); // Muestra un mensaje en la consola para confirmar que la puerta se ha abierto
    }
}
