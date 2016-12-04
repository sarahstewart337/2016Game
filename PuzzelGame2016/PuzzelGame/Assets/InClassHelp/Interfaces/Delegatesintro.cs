/*using UnityEngine;
using System;

public class Delegatesintro : MonoBehaviour
 
 {

	 public static Action MyEvent;
	 public static Action<string> EventWithArgs;

	 public delegate string DelString();
	 public static DelString EventString;

	 public static func <string,string> EvtReturnArgs;

	// Use this for initialization
	void Start ()
	 {
		 string data = EvtReturnArgs("CATS!!!");

		 print(data);
		 print(EventString());
		 EventString();
		 EventWithArgs ("Hello World");
		 MyEvent();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
*/