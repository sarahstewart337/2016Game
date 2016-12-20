using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxList : MonoBehaviour
{
    public List <int> box = new List<int>();

	// Use this for initialization
	void Start ()
    {
        box.Add(Random.Range(1, 100));
		
	}
	

}
