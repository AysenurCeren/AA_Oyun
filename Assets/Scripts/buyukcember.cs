using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyukcember : MonoBehaviour
{
    public float h�z;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0,0,h�z*Time.deltaTime); //(x,y,z) de�erleri Time.deltaTime= her cihazda ayn� �al��mas� i�in eklendi
    }
}
