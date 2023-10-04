using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Renderer[] renderers;

    private MaterialPropertyBlock _materialRed;
    private MaterialPropertyBlock MaterialRed
    {
        get
        {
            if (_materialRed == null)
                _materialRed = new();
            return _materialRed;
        }
    }

    private MaterialPropertyBlock _materialWhite;
    private MaterialPropertyBlock MaterialWhite
    {
        get
        {
            if (_materialWhite == null)
                _materialWhite = new();
            return _materialWhite;
        }
    }

    private void Start()
    {
        MaterialRed.SetColor("_Color", Color.red);
        MaterialWhite.SetColor("_Color", Color.white);
    }

    /*public override void OnHit()
    {
        StartCoroutine("ColorChange");
    }*/

    public IEnumerator ColorChange()
    {

        foreach (Renderer renderer in renderers)
        {
            renderer.SetPropertyBlock(_materialRed);
        }
        yield return new WaitForSeconds(0.3f);
        foreach (Renderer renderer in renderers)
        {
            renderer.SetPropertyBlock(_materialWhite);
        }
    }


}
