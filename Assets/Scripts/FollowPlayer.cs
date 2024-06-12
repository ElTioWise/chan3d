using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // El personaje que los objetos seguirán
    public float followSpeed = 2f; // Velocidad a la que los objetos seguirán al personaje
    public float stoppingDistance = 1f; // Distancia mínima al personaje antes de detenerse

    void Update()
    {
        if (target != null)
        {
            // Calcular la distancia hacia el objetivo
            float distance = Vector3.Distance(transform.position, target.position);

            // Comprobar si la distancia es mayor que la distancia mínima
            if (distance > stoppingDistance)
            {
                // Calcular la posición deseada hacia la que moverse
                Vector3 direction = (target.position - transform.position).normalized;
                Vector3 movePosition = transform.position + direction * followSpeed * Time.deltaTime;

                // Mover el objeto hacia la posición deseada
                transform.position = movePosition;
            }
        }
    }
}
