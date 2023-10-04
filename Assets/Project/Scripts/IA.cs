using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    private bool estarAlerta;
   
    
    void Start()
    {

    }


    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if (estarAlerta == true)
        {
           
            transform.LookAt(new Vector3(jugador.position.x, jugador.position.y, jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x, jugador.position.y, jugador.position.z), velocidad * Time.deltaTime);
        }

        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
       
    }
}
