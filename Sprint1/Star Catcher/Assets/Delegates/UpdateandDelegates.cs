using UnityEngine;
using System.Collections;
using System;

public class UpdateandDelegates : MonoBehaviour
{
    int health = 200;
    //Actions are a type of delegate. Delegates contains, functions jsut as vars contain data.
    Action DisplayHealth;
    Action KillthePlayer;
    Action EndtheGame;  
	// Use this for initialization
	void Start ()
    {
        //we assign teh function DisplayHealthHandler to the action DisplayHealth
        DisplayHealth = DisplayHealthHandler;
	}
    void EndtheGameHandler()
    {
        print("You Died. You didn't even try. you lose.");
    }

    void KillthePlayerHandler()
    {
        health--;
        print(health);
        if (health < 0)
        {
            KillthePlayer = null;
            EndtheGame = EndtheGameHandler;
        }
    }

    void DisplayHealthHandler()
    {
        print("Health is Good");
        //We unassign all functions from the DisplayHealth
        DisplayHealth = null;
        KillthePlayer = KillthePlayerHandler;
    }

	// Update is called once per frame
	void Update ()
    {
        // WE check if any function is assigned to DisplayHealt
        // if nothing is assigned DisplayHealth will not run
        if(DisplayHealth!= null)
        DisplayHealth();

        if (KillthePlayer != null)
            KillthePlayer();

        if (EndtheGame != null)
            EndtheGame();
	
	}
}
