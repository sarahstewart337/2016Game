using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Passing : MonoBehaviour
{
    public int speed = 3;
    public static Action<int> Speed;

	// Use this for initialization
	void Start ()
    {
        Speed += SpeedHandler;
	}
    private void OnTriggerEnter(Collider other)
    {
        Speed(speed);
    }

    public void SpeedHandler(int speed)
    {
        print("the character is running " + speed + "mph");

    }
}
