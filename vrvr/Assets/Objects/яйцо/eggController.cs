using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggController : MonoBehaviour
{
    public Animator eggAnimator;
    
    void OnTriggerEnter(Collider collider){
        
        if (collider.gameObject.tag == "Player"){
            
            eggAnimator.SetTrigger("on");
   
        }
    }
}
