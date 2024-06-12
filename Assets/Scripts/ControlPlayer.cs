using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    float speed = 5.0f;
    float angle = 5.0f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis( "Horizontal" );
        float vertical = Input.GetAxis( "Vertical" );

        transform.Rotate( 0, horizontal*angle, 0, Space.Self );

        Vector3 moveDirection = new Vector3( 0, 0, vertical );
        moveDirection = transform.rotation * moveDirection;
        transform.position += ( moveDirection * speed * Time.deltaTime );
        // detectar si vertical es mayor a 0 y cambiar la animación
        if( vertical > 0 )
        {
            animator.SetInteger( "Estado", 1 );
        }
        else
        {
            animator.SetInteger("Estado", 0);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto con el que colisionamos tiene el tag "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Cambiar el parámetro "Estado" a 2
            animator.SetBool("Dead", true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto con el que colisionamos tiene el tag "Enemy"
        if (other.CompareTag("Enemy"))
        {
            // Cambiar el parámetro "Estado" a 2
            animator.SetBool("Dead", true);
        }
    }
}
