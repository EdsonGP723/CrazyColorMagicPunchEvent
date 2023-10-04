using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{

    public static int life = 50;

    void Update()
    {
        if (life == 0)
        {
            Debug.Log("Game Over");
        }
    }
}
