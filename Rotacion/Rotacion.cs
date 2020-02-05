using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public Vector3 rotacion = new Vector3(0.8f, 2, 0);
    public float velocidad;
    bool parar = false;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 90f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        stop();
        if (parar == true)
        {
            velocidad = 0;
        }
        else
        {
            velocidad = 90f * Time.deltaTime;
            transform.Rotate(rotacion * velocidad, Space.World);

        }
    }

    void stop()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            parar = !parar;
        }
    }
}

    