using UnityEngine;
using System.Collections;

public interface IPowerUp
{
    //get means ican get information about the power
    //and you can now set the power
    int power { get; set; }

    // the function start is required
    void Start();
    //every power up is going to require ONTriggerEnter no matter what
    void OnTriggerEnter();
	
}

