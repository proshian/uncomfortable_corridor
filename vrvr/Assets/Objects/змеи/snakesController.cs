using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakesController : MonoBehaviour
{
    public Animator snakesAnimator;
    
    void OnTriggerEnter(Collider collider){
        
        if (collider.gameObject.tag == "Player"){
            
            snakesAnimator.SetTrigger("on");
   
        }
    }
}
