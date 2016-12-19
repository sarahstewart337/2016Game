using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	
	void Start ()
    {
        StartCoroutine(Hey());
	}
	
    IEnumerator Hey()
    {
        yield return new WaitForSeconds(3);
        print("Hello Welcome to this awesom game!");
    }

	
}
