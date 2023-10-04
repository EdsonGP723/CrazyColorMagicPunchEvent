using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int quantity = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.CompareTag("enemy"))
        {
            
            Debug.Log("le dio");
        }

    }
}
