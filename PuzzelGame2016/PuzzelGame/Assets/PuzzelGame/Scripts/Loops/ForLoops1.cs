using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops1 : MonoBehaviour
{
    int doors = 4;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < doors; i++)
        {
            Debug.Log("Creating door number: " + i);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
