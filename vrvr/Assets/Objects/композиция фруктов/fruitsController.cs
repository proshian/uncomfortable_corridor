using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitsController : MonoBehaviour
{
    public Animator fruitsAnimator;
    
    void OnTriggerEnter(Collider collider){
        
        if (collider.gameObject.tag == "Player"){
            
            fruitsAnimator.SetTrigger("on");
   
        }
    }
}
