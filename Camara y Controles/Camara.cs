﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camara : MonoBehaviour
{
    //Posiciones Camara
    public enum PosicionCamara { pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, free}
    public PosicionCamara miEstadoCamara = PosicionCamara.pos1;

    //Planetas
    //Elige los planetas en el orden que tu quieras
    public GameObject[] planetas;

    public GameObject planetaObservado;
    public Transform transformplaneta;

    //Camara
    public float miEjeRatonHorizontal;
    public float miEjeRatonVertical;
    public float velocidad = 2f;
    float desplazamientoX;
    float desplazamientoY;
    float desplazamientoZ;
    Vector3 movimientoY = new Vector3(0, -1, 0);
    public float sensibilidad = 50f;
    public Camera miCamara;
    public float fovActual = 60f;


    //Parar
    bool parar = false;

    public Vector3 tempRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Mirar Sol Al Principio
        planetaObservado = planetas[0];
        transformplaneta = planetaObservado.transform;
        transform.LookAt(transformplaneta);

        //Quitar Raton
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = !enabled;
    }

    // Update is called once per frame
    void Update()
    {
        stop();
        if (parar == true)
        {
            velocidad = 0;

            //Poner Raton
            Cursor.visible = enabled;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            //Quitar Raton
            Cursor.visible = !enabled;
            Cursor.lockState = CursorLockMode.Locked;

            //Mirar Sol
            if (Input.GetKey(KeyCode.Alpha1))
            {
                miEstadoCamara = PosicionCamara.pos1;
            }
            if (miEstadoCamara == PosicionCamara.pos1)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[0];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel")>0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f ;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Mercurio
            if (Input.GetKey(KeyCode.Alpha2))
            {
                miEstadoCamara = PosicionCamara.pos2;
            }
            if (miEstadoCamara == PosicionCamara.pos2)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[1];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Venus
            if (Input.GetKey(KeyCode.Alpha3))
            {
                miEstadoCamara = PosicionCamara.pos3;
            }
            if (miEstadoCamara == PosicionCamara.pos3)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[2];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Tierra
            if (Input.GetKey(KeyCode.Alpha4))
            {
                miEstadoCamara = PosicionCamara.pos4;
            }
            if (miEstadoCamara == PosicionCamara.pos4)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[3];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Luna
            if (Input.GetKey(KeyCode.Alpha5))
            {
                miEstadoCamara = PosicionCamara.pos5;
            }
            if (miEstadoCamara == PosicionCamara.pos5)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[4];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Marte
            if (Input.GetKey(KeyCode.Alpha6))
            {
                miEstadoCamara = PosicionCamara.pos6;
            }
            if (miEstadoCamara == PosicionCamara.pos6)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[5];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Saturno
            if (Input.GetKey(KeyCode.Alpha7))
            {
                miEstadoCamara = PosicionCamara.pos7;
            }
            if (miEstadoCamara == PosicionCamara.pos7)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[6];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Saturno
            if (Input.GetKey(KeyCode.Alpha8))
            {
                miEstadoCamara = PosicionCamara.pos8;
            }
            if (miEstadoCamara == PosicionCamara.pos8)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[7];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Urano
            if (Input.GetKey(KeyCode.Alpha9))
            {
                miEstadoCamara = PosicionCamara.pos9;
            }
            if (miEstadoCamara == PosicionCamara.pos9)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[8];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            //Mirar Neptuno
            if (Input.GetKey(KeyCode.Alpha0))
            {
                miEstadoCamara = PosicionCamara.pos10;
            }

            
            if (miEstadoCamara == PosicionCamara.pos10)
            {
                tempRotation = transform.rotation.eulerAngles;
                planetaObservado = planetas[9];
                transformplaneta = planetaObservado.transform;
                transform.LookAt(transformplaneta);
                if (Input.GetAxis("Mouse ScrollWheel") > 0 && miCamara.fieldOfView > 10)
                {
                    miCamara.fieldOfView = fovActual - 2f;
                    fovActual = miCamara.fieldOfView;
                }
                if (Input.GetAxis("Mouse ScrollWheel") < 0 && miCamara.fieldOfView < 100)
                {
                    miCamara.fieldOfView = fovActual + 2f;
                    fovActual = miCamara.fieldOfView;
                }
            }

            

            //Camara Libre
            if (Input.GetKey(KeyCode.Tab))
            {
                miEstadoCamara = PosicionCamara.free;
                miEjeRatonHorizontal = tempRotation.y;
                miEjeRatonVertical = transform.rotation.x - 0.145f;
            }
            if (miEstadoCamara == PosicionCamara.free)
            {
                fovActual = 60;
                miCamara.fieldOfView = fovActual;

                //Controles Raton
                miEjeRatonHorizontal += Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
                miEjeRatonVertical += Input.GetAxis("Mouse Y") * sensibilidad * Time.deltaTime;
                miEjeRatonVertical = Mathf.Clamp(miEjeRatonVertical, -90f, 90f);
                transform.rotation = Quaternion.Euler(tempRotation.x, miEjeRatonHorizontal, tempRotation.z);
                transform.Rotate(Vector3.left * miEjeRatonVertical, Space.Self);

                //Controles Movimiento
                desplazamientoX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
                desplazamientoZ = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
                transform.Translate(desplazamientoX, 0, desplazamientoZ);

                //Controles Bajar
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    transform.Translate(movimientoY * velocidad * Time.deltaTime);
                }

                //Controles 
                if (Input.GetKey(KeyCode.Space))
                {
                    transform.Translate(-movimientoY * velocidad * Time.deltaTime);
                }

                //Subir Velocidad
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    velocidad = 10f;
                    desplazamientoX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
                    desplazamientoZ = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
                    transform.Translate(desplazamientoX, 0, desplazamientoZ);
                }
            }
        
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
