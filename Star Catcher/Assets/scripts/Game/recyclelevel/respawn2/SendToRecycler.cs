using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour
{
    public bool canRecycle;
    public static Action<SendToRecycler> sendThis;

	void Start ()
    {
        if(canRecycle)
        //calling is as a funtion and passing itself
         sendThis(this);

	}
	
    void OnTriggerEnter ()
    {
        canRecycle = true;
        Start();
    }
	
}
