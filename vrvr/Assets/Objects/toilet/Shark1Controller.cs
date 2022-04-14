using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark1Controller : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            this.GetComponent<Animator>().SetTrigger("show");
        }
    }
    
    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            this.GetComponent<Animator>().SetTrigger("true");
        }
        
    }
}
