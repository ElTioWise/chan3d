using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // El personaje que los objetos seguir�n
    public float followSpeed = 2f; // Velocidad a la que los objetos seguir�n al personaje
    public float stoppingDistance = 1f; // Distancia m�nima al personaje antes de detenerse

    void Update()
    {
        if (target != null)
        {
            // Calcular la distancia hacia el objetivo
            float distance = Vector3.Distance(transform.position, target.position);

            // Comprobar si la distancia es mayor que la distancia m�nima
            if (distance > stoppingDistance)
            {
                // Calcular la posici�n deseada hacia la que moverse
                Vector3 direction = (target.position - transform.position).normalized;
                Vector3 movePosition = transform.position + direction * followSpeed * Time.deltaTime;

                // Mover el objeto hacia la posici�n deseada
                transform.position = movePosition;
            }
        }
    }
}
