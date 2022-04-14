using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform target;
    public GameObject eye;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = eye.transform.position;
        eye.transform.LookAt(target);
        //eye.transform.rotation = Quaternion.Inverse(eye.transform.rotation); 
        //eye.transform.rotation = eye.transform.rotation * (-1);
        //eye.transform.position = position;
    }
}
