using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PunchSystem : MonoBehaviour
{
    public PlayerInput inputs;
    [Header ("Target L")]
    public Transform targetL;
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

        if (inputs.actions["PunchR"].WasPressedThisFrame()){
            Debug.Log("Golpe izquierdo");
            StartCoroutine(PunchR());
        }
        
    }

    public IEnumerator PunchL(){
        targetL.position += targetL.forward;
        yield return new WaitForSeconds(.3f);
        targetL.position = targetLPos.position;
    }

    public IEnumerator PunchR(){
        targetR.position += targetR.forward;
        yield return new WaitForSeconds(.3f);
        targetR.position = targetRPos.position;
    }

    
}
