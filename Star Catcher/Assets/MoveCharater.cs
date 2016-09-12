using UnityEngine;
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
    public int jumpCountMax;
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
        // test if character controller is grounded
       if(myCC.isGrounded)
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
