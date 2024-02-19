using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia al transform del personaje a seguir
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del seguimiento
    public Vector3 offset; // Offset de la posición de la cámara respecto al personaje

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Ajustamos la posición de la cámara al plano Z
            transform.position = new Vector3(transform.position.x, transform.position.y, -10f); // Ajustamos la posición Z a -10 (z negativo es hacia adentro en Unity)
        }
    }
}