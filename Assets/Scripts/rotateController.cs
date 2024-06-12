using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class rotateController : MonoBehaviour
{
    public Transform target;
    public float velocidadGiro = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, Vector3.up, velocidadGiro * Time.deltaTime);
    }
}
