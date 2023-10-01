using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    public int vida = 100;


    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        Rigidbody rb;
        if (vida == 0)
        {
           // rb.gameObject.GetComponent<Rigidbody>().i
        }
    }
}
