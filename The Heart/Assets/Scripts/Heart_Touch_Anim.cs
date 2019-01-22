using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Touch_Anim : MonoBehaviour {

    public GameObject cube_collide;
    
    private Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cube_collide")
        {
            
            anim.Play("Icosphere|IcosphereAction");
            Debug.Log("collision");
        }
    }
}
