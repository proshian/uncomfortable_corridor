using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public Animator heartAnimator;

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
           heartAnimator.SetTrigger("pulse");
        }
    }
    
}
