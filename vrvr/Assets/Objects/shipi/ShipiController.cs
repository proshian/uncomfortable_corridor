using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipiController : MonoBehaviour
{
    public Animator shipiAnimator;


    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            shipiAnimator.SetTrigger("show");
        }
    }
    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            shipiAnimator.SetTrigger("hide");
        }
        
    }
}