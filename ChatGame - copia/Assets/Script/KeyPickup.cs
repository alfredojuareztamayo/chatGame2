using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool hasKey = false; // Variable para rastrear si el jugador tiene la llave

    // Método que se llama cuando el jugador toca la llave
    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el jugador toca la llave y aún no la tiene
        if (!hasKey && other.CompareTag("Player"))
        {
            hasKey = true;
            Destroy(gameObject); // Destruye el objeto de la llave
            Debug.Log("¡Has recogido la llave!"); // Muestra un mensaje en la consola para confirmar la recogida de la llave
        }
    }
}
