using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarControles : MonoBehaviour
{
    public GameObject[] miTextos;
    public bool[] textos;
    public GameObject raton;
    // Start is called before the first frame update
    void Start()
    {
        miTextos = GameObject.FindGameObjectsWithTag("Texto");
        textos = new bool[] { true, false, false, true};
        miTextos[0].SetActive(textos[0]);
        miTextos[1].SetActive(textos[1]);
        miTextos[2].SetActive(textos[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            textos[0] = !textos[0];
            miTextos[0].SetActive(textos[0]);
            textos[1] = !textos[1];
            miTextos[1].SetActive(textos[1]);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            textos[2] = !textos[2];
            miTextos[2].SetActive(textos[2]);
            textos[3] = !textos[3];
            raton.SetActive(textos[3]);
        }
    }
}
