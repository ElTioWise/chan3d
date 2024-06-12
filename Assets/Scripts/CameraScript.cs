
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El personaje al que la c�mara seguir�
    public Vector3 offset; // Desplazamiento de la c�mara respecto al personaje
    public float smoothSpeed = 0.125f; // Velocidad de suavizado

    void FixedUpdate()
    {
        if (target != null)
        {
            // Posici�n deseada de la c�mara con el desplazamiento
            Vector3 desiredPosition = target.position + offset;

            // Suavizar la transici�n hacia la posici�n deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Actualizar la posici�n de la c�mara
            transform.position = smoothedPosition;

            // Mirar hacia el personaje (opcional)
            transform.LookAt(target);
        }
    }
}