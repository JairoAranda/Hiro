using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarCamara : MonoBehaviour
{
    public GameObject camara;
    Transform transformcamara;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transformcamara = camara.transform;
        transform.LookAt(transformcamara);
    }
}
