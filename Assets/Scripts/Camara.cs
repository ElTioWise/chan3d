using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Camara : MonoBehaviour
{
    public Transform target;
    public float distance = 5f;
    public float velocidadGiro = 10f;
    public string nombreEscena;
    void Start()
    {
        transform.LookAt( target.position );
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z - distance);
    }

    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, velocidadGiro * Time.deltaTime);
    }
    // detectar cuando hayan pasado 20 segundos y bloquear la camara o cuando precione la tecla de espacio
    void FixedUpdate()
    {
        if (Time.time > 20 || Input.GetKey(KeyCode.Space))
        {
            velocidadGiro = 0;
            CambiarEscena();
        }
    }
   // Función para cambiar de escena en unity
       public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
