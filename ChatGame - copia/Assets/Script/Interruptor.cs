using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Referencia al componente SpriteRenderer del interruptor
    public Color verdeColor = Color.green; // Color verde
    public Color rojoColor = Color.red; // Color rojo

    private int valorInterruptor = 1; // Valor inicial del interruptor (verde)

    void Start()
    {
        // Inicializa el color del interruptor al color verde
        CambiarColor(verdeColor);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el jugador interactúa con el interruptor
        if (other.CompareTag("Player"))
        {
            // Si el jugador presiona la tecla "E"
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Cambia el color del interruptor y actualiza su valor
                if (valorInterruptor == 1)
                {
                    CambiarColor(rojoColor);
                    valorInterruptor = 2;
                }
                else if (valorInterruptor == 2)
                {
                    CambiarColor(verdeColor);
                    valorInterruptor = 1;
                }
            }
        }
    }

    // Método para cambiar el color del interruptor
    void CambiarColor(Color color)
    {
        spriteRenderer.color = color;
    }
}