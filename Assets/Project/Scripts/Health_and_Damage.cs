using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_and_Damage : MonoBehaviour
{
    
    public static int life = 30;
    

    public void SubstractLife(int quantity)
    {
        life -= quantity;
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if (life == 0)
        {
            Debug.Log("ya no tiene vida");
        }
    }
}
