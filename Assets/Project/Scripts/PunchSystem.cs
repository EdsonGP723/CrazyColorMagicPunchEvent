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

    public Collider leftCol, rightCol;
    
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
        leftCol.enabled = enabled;
        yield return new WaitForSeconds(.3f);
        targetL.position = targetLPos.position;
        leftCol.enabled = !enabled;
    }

    public IEnumerator PunchR(){
        targetR.position += targetR.forward;
        rightCol.enabled = enabled;
        yield return new WaitForSeconds(.3f);
        targetR.position = targetRPos.position;
        rightCol.enabled = !enabled;
    }

    
}
