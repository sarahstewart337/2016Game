using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    public CharacterController myCC;
    public float Speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    private Vector3 tempPos;
    // Use this for initialization
    void Start ()
    {
        myCC = GetComponent<CharacterController>();

    }
	
	// Update is called once per frame
	void Update () {
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
            
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls coroutine. Use the coroutine in the argument
            
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
