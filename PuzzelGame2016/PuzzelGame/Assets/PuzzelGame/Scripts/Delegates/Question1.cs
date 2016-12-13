using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Question1 : MonoBehaviour
{
    public static Action Hint;


    void OnTriggerEnter()
    {
        
        Hint();
    }


}