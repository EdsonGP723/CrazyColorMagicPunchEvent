using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PunchSystem : MonoBehaviour
{
    public PlayerInput inputs;
    [Header ("Target L")]
    public Transform targetL;
    public Vector3 targetLVec;
    public Transform targetLPos;
    [Header ("Target R")]
    public Transform targetR;
    public Transform targetRPos;
    
    private void Start() {
        
    }
    
    private void Update() {
        if (inputs.actions["PunchL"].WasPressedThisFrame()){
            Debug.Log("Golpe izquierdo");
            StartCoroutine(PunchL());
        }
        
    }

    public IEnumerator PunchL(){
        Vector3 Adelante = Direction();
        yield return new WaitForSeconds(.3f);
        targetL.position = targetLPos.position;
    }

    public Vector3 Direction(){
        Vector3 Foward = targetL.forward;
        Foward.Normalize();
        return Foward;
    }
}
