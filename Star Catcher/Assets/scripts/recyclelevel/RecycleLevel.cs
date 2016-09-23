﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevel : MonoBehaviour
{

    private Vector3 newLocation;
    public List<Recycler> recyclableList;
    private int i = 0;

    //subscribe to the list action call
    void Start ()
    {
        recyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        recyclableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
        newLocation.x = StaticVars.nextSectionPosition;
        recyclableList[i].cube.position = newLocation;
        StaticVars.nextSectionPosition += StaticVars.distance;
        if(recyclableList.Count > 0)
        recyclableList.RemoveAt(i);
      
           
        

    }
}