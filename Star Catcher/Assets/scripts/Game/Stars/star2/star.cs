using UnityEngine;
using System.Collections;
using System;

public class star : MonoBehaviour
{
    public static Action<Transform> SendStar;

	// Use this for initialization
	void Start ()
    {
        GetComponent<MeshRenderer>().enabled = false;
        if(SendStar)
        SendStar(transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
