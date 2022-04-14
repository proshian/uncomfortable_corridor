using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smthController : MonoBehaviour
{
    public Animator smthAnimator;

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            smthAnimator.SetTrigger("start");
            smthAnimator.SetTrigger("loop");
        }
    }
    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            smthAnimator.SetTrigger("end");
        }
        
    }
}
