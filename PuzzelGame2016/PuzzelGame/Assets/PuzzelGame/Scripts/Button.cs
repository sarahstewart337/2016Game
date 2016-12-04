using UnityEngine;
using System.Collections;
using System;

public class Button : MonoBehaviour, IOpen {

   

    public void OnTriggerEnter()
    {
        print("open door");
    }

    void IOpen.Start()
    {
        throw new NotImplementedException();
    }


	
	
}
