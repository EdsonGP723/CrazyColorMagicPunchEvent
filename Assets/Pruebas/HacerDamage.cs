using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDamage : MonoBehaviour
{
    public int cantidad = 10;
    private Renderer m;
    
    void Start()
    {
        m = GetComponent<Renderer>();
    }

    
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<SistemaVida>().RestarVida(cantidad);
            m.material.SetColor("rojo", Color.red);


        }
    }
}
