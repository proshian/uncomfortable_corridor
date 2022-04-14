using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dollController : MonoBehaviour
{
    public Animator dollAnimator;
    
    void OnTriggerEnter(Collider collider){
        
        if (collider.gameObject.tag == "Player"){
            
            dollAnimator.SetTrigger("show");
   
        }
    }
}
