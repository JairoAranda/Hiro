using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaLuna : MonoBehaviour
{
    public GameObject Tierra;
    public Vector3 eje = Vector3.up;
    public Vector3 origen;
    public float velAngular;
    bool parar = false;
    // Start is called before the first frame update
    void Start()
    {
       Tierra = GameObject.Find("Tierra");
        if (Tierra != null)
        {
            origen = Tierra.transform.position;
        }
        else
        {
            Debug.Log("No se ha encontrado Tierra");
        }
        velAngular = 90 * Time.deltaTime;
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
            velAngular = 90 * Time.deltaTime;
            transform.RotateAround(origen, eje, velAngular);
            origen = Tierra.transform.position;
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
