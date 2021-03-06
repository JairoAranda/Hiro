﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaUrano : MonoBehaviour
{
    public GameObject Sol;
    public Vector3 eje = Vector3.up;
    public Vector3 origen;
    public float velAngular;
    bool parar = false;
    // Start is called before the first frame update
    void Start()
    {
        stop();
        if (parar == true)
        {
            velAngular = 0;
        }
        else
        {
            Sol = GameObject.Find("Sol");
            if (Sol != null)
            {
                origen = Sol.transform.position;
            }
            else
            {
                origen = Vector3.zero;
            }
            velAngular = 4 * Time.deltaTime;
        }
       
    }

    // Update is called once per frame
    void Update()
    {

        stop();
        if (parar == true)
        {
            velAngular = 0;
        }
        else
        {
            velAngular = 4 * Time.deltaTime;

            transform.RotateAround(origen, eje, velAngular);
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
