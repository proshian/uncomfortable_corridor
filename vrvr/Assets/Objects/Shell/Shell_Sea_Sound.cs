using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell_Sea_Sound : MonoBehaviour
{
    public AudioSource sea_sound_audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "Player"){
            sea_sound_audio.Play();
        }
    }

    void OnTriggerExit(Collider collider){
        if (collider.gameObject.tag == "Player"){
            sea_sound_audio.Stop();
        }
    }
}
