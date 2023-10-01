using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    public int vida = 100;
    private Rigidbody rb;

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }

    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
       
        if (vida == 0)
        {
            rb.gameObject.GetComponent<Rigidbody>().mass = 0.1f;
        }
    }
}
