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
    private bool puedeAtacar;
    public float rangoAtaque;



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
        puedeAtacar = Physics.CheckSphere(transform.position, rangoAtaque, capaDelJugador);

        if (puedeAtacar == true)
        {

            //animator.SetBool("estaAtacando", true);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerLife.life -= 10;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoAtaque);

    }
}
