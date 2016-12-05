using UnityEngine;
using System.Collections;
using System;

public class Button : MonoBehaviour{

	public Animator anim = null;

  

    public void Start()
    {
		anim = GetComponent<Animator> ();
    }


	public void OnTriggerEnter(Collider collider)
	{
		anim.SetBool ("isOpen", false);
	}
	
}
