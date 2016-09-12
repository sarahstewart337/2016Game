using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour
{
    public float speed = 10;
    // used to move the player
    private CharacterController controller;
    public float gravity = -9.81f;

    //used to assign location as a temo var
    private Vector3 tempPosition;
	// Use this for initialization
	void Start ()
    {
        controller = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Fake Gravity
        tempPosition.y = gravity;
        //Using Axis as an input with speed the character can hold or move left and right
        tempPosition.x = speed*Input.GetAxis("Horizontal");
        tempPosition *= Time.deltaTime;
        //move method take the temp vector3 to move
        controller.Move(tempPosition);
	}
}
