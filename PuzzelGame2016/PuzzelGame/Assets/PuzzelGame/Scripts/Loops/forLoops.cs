using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoops : MonoBehaviour
{
    int blocks = 3;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < blocks; i++)
        {
            Debug.Log("Creating block number: " + i);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
