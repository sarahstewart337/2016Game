using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLvl : MonoBehaviour
{
    private Vector3 movePos;

    private List<SendToRecycler> recycleList;
    void SendThisHandler (SendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }

	// Use this for initialization
	void Start ()
    {
        recycleList = new List<SendToRecycler>();
        SendToRecycler.sendThis += SendThisHandler;


    }

    void OnTriggerEnter()
    {
        movePos.x = statics.nextPosition;
        recycleList[0].transform.position = movePos;
        statics.nextPosition += statics.distance;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
