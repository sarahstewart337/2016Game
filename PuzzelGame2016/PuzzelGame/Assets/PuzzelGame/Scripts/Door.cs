using UnityEngine;
using System.Collections;
using System;

public class Door : MonoBehaviour
{

    public int openDoor;
   public Vector3 position;
    private bool buttonClicked = false;
    public GameObject door;

  

    public void Start()
    {
       

    }

    public void moveDoor()
    {
        openDoor = Statics.activeTriggers;
        
        switch (openDoor)
        {
            case 1:
               door.transform.position = new Vector3(0, .5f, 0);
                break;

            case 2:
                door.transform.position = new Vector3(0, 3, 0);
                break;
        }
    }

        
       

   
	//public void MoveDoor()
   // {
       
    //}

    public void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(0, 5, 0);
        print(transform.position.y);
    }
}
