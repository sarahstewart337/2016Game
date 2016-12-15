using UnityEngine;
using System.Collections;
using System;

public class Door : MonoBehaviour
{

    public int openDoor;
   public Vector3 position;

    public GameObject door;
    public static Action<int> moveSteps;
    public bool canClick = true;

  

    public virtual void Start()
    {
        Character.Flying += FlyingHandler;

    }
   

    public virtual void MoveObject()
    {

    }
    public virtual void moveDoor()
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

        public void FlyingHandler(int flightSpeed)
    {
        print("The door is flying" + flightSpeed + " kmh");
    }

    public void SpeedHandler(int speed)
    {
        print("the door is running " + speed + "mph");

    }

    public void TriggerSwitch(int buttonTicks)
    {
        buttonTicks = Statics.buttonTicks;
        switch(buttonTicks)
        {
            case 1:
                moveSteps(buttonTicks);
                break;
            case 2:
                moveSteps(buttonTicks);
                break;
            case 3:
                moveSteps(buttonTicks);
                break;
            default:
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

        Statics.buttonTicks++;
        moveSteps(Statics.buttonTicks);

    }
}
