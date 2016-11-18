﻿using UnityEngine;
using System.Collections;

public class Overloading : MonoBehaviour {

	// Use this for initialization
	void Update ()
    {
        Move(50);
	
	}
	
	// Update is called once per frame
	void Move (int speed)
    {
        Vector3 vector = new Vector3(speed, 0, 0);
        transform.position = vector*Time.deltaTime;
    }
    void Move (string speed)
    {
        Vector3 vector = Vector3.zero;
        switch(speed)
        {
            case "Fast":
                 vector = new Vector3(100, 0, 0);
                break;
            case "Slow":
                vector = new Vector3(1, 0, 0);
                break;
        }
        transform.position += vector*Time.deltaTime;
    }
}
