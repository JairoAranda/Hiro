using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuego : MonoBehaviour
{
    public Canvas cerrar;
    public void Quit()
    {
        Application.Quit();
    }

    void Start()
    {
        cerrar.enabled = !cerrar.enabled;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cerrar.enabled = !cerrar.enabled;
        }
    }
}