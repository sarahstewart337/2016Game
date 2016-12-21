using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    delegate void MyDelegate (int myInt);
    MyDelegate myDelegate;

	// Use this for initialization
	void Start ()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
	}
	
    void PrintNum (int myInt)
    {
        print("Print Num: " + myInt);
    }
    void DoubleNum(int myInt)
    {
        print("double Num: " + myInt * 2);
    }
	
}
