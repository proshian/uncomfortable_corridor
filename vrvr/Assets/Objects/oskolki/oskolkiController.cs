using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oskolkiController : MonoBehaviour
{
    public Animator oskolkiAnimator;
    
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            oskolkiAnimator.SetTrigger("start");
        }
    }
}
