using UnityEngine;
using System.Collections;
using System;

public static Action <KeyCode> UserInput;

public class UserInputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
       

      if (Input.GetKeyDown(KeyCode.RightArrow)&& UserInput != null)
        {
            UserInput(KeyCode.RightArrow);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && UserInput != null)
        {
            UserInput(KeyCode.LeftArrow);

        }

    }
}
