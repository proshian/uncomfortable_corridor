using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToiletController : MonoBehaviour
{
    public Animator shark1Animator;
    public Animator shark2Animator;
    public Animator toiletAnimator;

    public GameObject shark1;
    public GameObject shark2;

    private int c;


    void Start(){
        c = Random.Range(1,3);
        //c = 2;
        //Debug.Log(c);
        
    }

    void OnTriggerEnter(Collider collider){
        
        toiletAnimator.SetTrigger("state");
       
        if (collider.gameObject.tag == "Player"){
        
            if (c == 1){
               
                toiletAnimator.SetTrigger("case1");
                shark1Animator.SetTrigger("show1");
            }
            else{
                shark2.SetActive(true);
                toiletAnimator.SetTrigger("case2");
                shark2Animator.SetTrigger("show2");
                shark2Animator.SetTrigger("loop");
            }
   
        }
    }
    
    void OnTriggerExit(Collider collider){
       
       if (c == 1){
            shark1Animator.SetTrigger("hide1");
        }

    }
        
    
    
}
