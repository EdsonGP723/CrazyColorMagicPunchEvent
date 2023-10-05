using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    public Animator animator;
    public Collider mainCollider;
    public Rigidbody mainRigidbody;
    private IA ia;

    public List<Rigidbody> rigidbodies;
    public List<Collider> colliders;
    // Start is called before the first frame update
    void Start()
    {
        ia = GetComponent<IA>();
        foreach (var item in GetComponentsInChildren<Rigidbody>())
        {
            if (item.gameObject != this.gameObject)
            {
                rigidbodies.Add(item);
                item.isKinematic = true;
                item.useGravity = false;
            }
        }

        foreach (var item in GetComponentsInChildren<Collider>())
        {
            if (item.gameObject != this.gameObject)
            {
                colliders.Add(item);
                item.enabled = false;
            }
        }
        mainCollider = GetComponent<Collider>();

        mainRigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    bool value = true;
    public void Toggle()
    {
        value = !value;

        foreach (var item in colliders)
        {
            item.enabled = !value;
        }

        foreach (var item in rigidbodies)
        {
            item.isKinematic = value;
            item.useGravity = !value;
        }


        mainCollider.enabled = value;
        animator.enabled = value;
        mainRigidbody.isKinematic = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.tag == "Hit")
        {
            Health_and_Damage.life -= 10; 
            var rb = collision.collider.attachedRigidbody;
            rb.AddForce(-collision.contacts[0].normal * 100, ForceMode.Impulse);
            if (Health_and_Damage.life == 0)
            {
                value = true;
                ia.enabled = false;
               
                Toggle();
            }
            
        }
    }

}
