using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : Door,IOpen
{
    private bool canBeTriggered = true;

    public void OnTriggerEnter()
    {
        if (canBeTriggered == true)
        {
            canBeTriggered = false;
            Statics.activeTriggers += 1;
            moveDoor();
        }
    }
}
