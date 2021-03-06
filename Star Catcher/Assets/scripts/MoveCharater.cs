﻿using UnityEngine;
using System.Collections;

public class MoveCharater : MonoBehaviour
{
    
        // this is the character controller component
    private CharacterController myCC;
    //temp var of data type vector3 to move the character
    private Vector3 tempPos;
    //speed of temp car in x
    public float Speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //Sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.01f;
    //Coroutine for Sliding Character
    IEnumerator Slide ()
    {
        //set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float newSpeedTemp = Speed;
        Speed +=Speed;
        //while loops will run until true and then stop/ While loop runs while the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            //subtracts 1 from the slide duration
            slideDuration--;
            //yield "holds the coroutine"
            //return sends to the coroutine to do an operation while yielding
            // new creates an instance of an object
            //waitforseconds is an object that waits for a duration of time
            yield return new WaitForSeconds(slideTime);
            
        }
        slideDuration = durationTemp;
    }


   
    // Use this for initialization
    void Start ()
    {
        //This "Finds" the charaacter controller component
        myCC = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //waiting for input and comparing jumpCount
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount <= jumpCountMax-1)
        {
            //incrementing the jump count by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }

        //Start Sliding
        if(Input.GetKey(KeyCode.RightArrow)&& Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());
        }
        // test if character controller is grounded
        if (myCC.isGrounded)
        {
            // reset jump count if grounded
            jumpCount = 0;
        }
       

        // adding the gravity var to the y position of the tempPos var
        tempPos.y -= gravity;
        //adding the speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = Speed*Input.GetAxis("Horizontal");
        //moves the character controller at an even pace
        myCC.Move(tempPos * Time.deltaTime);
	}
}
