using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lentiController : MonoBehaviour
{
    public Animator lentiAnimator;
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            lentiAnimator.SetTrigger("true");
        }
    }
}
