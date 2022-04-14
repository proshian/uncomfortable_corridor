using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneController : MonoBehaviour
{
    public Animator phoneAnimator;
    
    //void OnTriggerEnter(Collider collider){
    public void phoneGrabbed(){
     //   if (collider.gameObject.tag == "Player"){
            phoneAnimator.SetTrigger("melt");
     //   }
    }
    
}
