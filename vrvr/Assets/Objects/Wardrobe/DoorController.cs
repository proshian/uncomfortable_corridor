using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator wardrobeController;

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            wardrobeController.SetTrigger("close");
        }
    }
    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            wardrobeController.SetTrigger("open");
        }
        
    }



}
