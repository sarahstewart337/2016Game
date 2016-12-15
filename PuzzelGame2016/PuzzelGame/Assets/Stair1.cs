using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair1 : Door, ISteps {
    public Transform stepPos;
    public int x;
    public int y;
    public int z;

    public override void Start()
    {
        Door.moveSteps += MoveStepHandler;
    }
    public void MoveObject(int buttonTicks)
    {
        if (buttonTicks == 1)
        {
            stepPos.transform.position = new Vector3(x, y, z);
        }
    }
    public void MoveStepHandler(int buttonTicks)
    {
        MoveObject(buttonTicks);
    }

    
}
