
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El personaje al que la cámara seguirá
    public Vector3 offset; // Desplazamiento de la cámara respecto al personaje
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void FixedUpdate()
    {
        if (target != null)
        {
            // Posición deseada de la cámara con el desplazamiento
            Vector3 desiredPosition = target.position + offset;

            // Suavizar la transición hacia la posición deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Actualizar la posición de la cámara
            transform.position = smoothedPosition;

            // Mirar hacia el personaje (opcional)
            transform.LookAt(target);
        }
    }
}