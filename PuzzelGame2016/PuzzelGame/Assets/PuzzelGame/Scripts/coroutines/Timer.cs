using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool canExplode = true ;
    public bool canRevive = false;

    IEnumerator Explode()
    {
        int i = 10;
      
        while( i > 0)
       {
            yield return new WaitForSeconds(1);
            print(i);
            i--;
        
        }
        yield return new WaitForSeconds(1);
        print("Boom!!");
        canRevive = true;
    }
    IEnumerator ImAlive()
    {
        int i = 1;
            while(i < 4)
        {
            yield return new WaitForSeconds(1);
            print(i);
            i++;



        }
        print("I'm Alive!!!");
        canExplode = true;
    }

    private void OnMouseDown()
    {
        if (canExplode == true)
        {
            canExplode = false;
            print("im gonna explode");
            StartCoroutine(Explode());
        }

        if(canRevive == true)
        {
            canRevive = false;
            print("Guess What?????");
            StartCoroutine(ImAlive());
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
