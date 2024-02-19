using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia al transform del personaje a seguir
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del seguimiento
    public Vector3 offset; // Offset de la posici�n de la c�mara respecto al personaje

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Ajustamos la posici�n de la c�mara al plano Z
            transform.position = new Vector3(transform.position.x, transform.position.y, -10f); // Ajustamos la posici�n Z a -10 (z negativo es hacia adentro en Unity)
        }
    }
}