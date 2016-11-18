using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start ()
    {
        Walk();
	
	}
	
	// Update is called once per frame
	void Walk ()
    {
        print("walk");
	
	}
}
