using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Handler : MonoBehaviour
{

    void Start()
    {
        Question1.Hint += HintHandler;
    }
    public void HintHandler()
    {
        print("jump on both blocks to fully open door!");
    }
}
