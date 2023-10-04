using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopiarRotacion : MonoBehaviour
{
    [SerializeField] private Transform targetLimb;
    [SerializeField] private CharacterJoint m_CharacterJoint;


    Quaternion targetInitialRotation;
    // Start is called before the first frame update
    void Start()
    {
        this.m_CharacterJoint = this.GetComponent<CharacterJoint>();
        this.targetInitialRotation = this.targetLimb.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
       // this.m_CharacterJoint.targetRotation = copyRotation();
    }

    private Quaternion copyRotation()
    {
        return Quaternion.Inverse(this.targetLimb.localRotation) * this.targetInitialRotation;
    }
}
