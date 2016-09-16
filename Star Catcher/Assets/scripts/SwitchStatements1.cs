using UnityEngine;
using System.Collections;
using System;

public class SwitchStatements1 : MonoBehaviour
{
    public enum gameStates { Starting, Playing, Ending }
    public gameStates currentState = gameStates.Starting;

	// Use this for initialization
	void Start ()
    {
        switch (currentState)
        {
            case gameStates.Starting:

                DoSomthing("starting");
                break;

            case gameStates.Playing:
                DoSomthing("Playing");
                break;

            case gameStates.Ending:
                DoSomthing("Ending");
                break;
        }
	
	}

    private void DoSomthing(string v)
    {
        print("The game is " + v);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
