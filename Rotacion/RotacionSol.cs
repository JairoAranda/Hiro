using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSol : MonoBehaviour
{
    public Vector3 rotacion = new Vector3(0.8f, 2, 0);
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 40f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * velocidad, Space.World);
    }
}
