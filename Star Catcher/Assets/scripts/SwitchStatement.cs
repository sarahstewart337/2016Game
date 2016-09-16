using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour
{
    const int apples = 8;
    const int oranges = 12;

	// Use this for initialization
	void Start ()
    {
        CompareAmount(12);
	}
	
	private void CompareAmount(int fruit)
    {
        switch (fruit)
        {
            case apples:
                print("I have ten apples");
                break;

            case oranges:
                print("I have ten oranges");
                break;

            default:
                print("I have no fruit equal to ten");
                break;

        }
    }
}
