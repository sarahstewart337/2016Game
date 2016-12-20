using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightsOn : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Lights());
		
	}
	
	IEnumerator Lights()
    {
        yield return new WaitForSeconds(2);
        print("I turned the lights on");
    }
}
