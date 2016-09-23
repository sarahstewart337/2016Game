using UnityEngine;
using System.Collections;

public class Temppos : MonoBehaviour 

	{


    private Vector3 newLocation;



    void OnTriggerEnter()
    {
        StaticVars.nextSectionPosition += StaticVars.distance;
        newLocation.x = StaticVars.nextSectionPosition;
        transform.position = newLocation;
    }

}
