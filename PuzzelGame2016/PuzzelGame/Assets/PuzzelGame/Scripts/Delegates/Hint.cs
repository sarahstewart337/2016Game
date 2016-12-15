using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Quesion : MonoBehaviour
{
    public static Action Hint;


    void OnTriggerEnter()
    {
        print("1");
        Hint();
    }
}