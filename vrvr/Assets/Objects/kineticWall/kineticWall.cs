using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kineticWall : MonoBehaviour
{
    public Material ripple;
    public Material noRipple;
    public Renderer rend;
    public Renderer kw1;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            rend.material = ripple;
            kw1.material = ripple;
        }
    }

    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            rend.material = noRipple;
            kw1.material = noRipple;
        }
    }
}
