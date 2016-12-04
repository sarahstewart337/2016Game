/*using UnityEngine;
using System.Collections;

public class EvenHandlerIntro : MonoBehaviour {

	// Use this for initialization
	void Start ()
	 {
		 Delegatesintro.MyEvent += MyEventHandler;
		 Delegatesintro.EventWithArgs += EventWithArgsHandler;
		 Delegatesintro.EventString += EventStringHandler;
		 Delegatesintro.EvtReturnArgs += EvtReturnArgsHandler;
	
	}
	private string EvtReturnArgsHandler(string s)
	{
		return " The animals I Hate Most Are " + s;
	}
	private  string EventStringHandler()
	{
		print("Do You Like Cats?");
		return "I Hate Cats";
	}
	
	private void MyEventHandler()
	{
		print("I Ran");
	}
	private void EventWithArgsHandler(string s)
	{
		print(s);
	}
}
*/
