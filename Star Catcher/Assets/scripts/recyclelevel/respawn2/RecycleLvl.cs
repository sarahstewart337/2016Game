using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLvl : MonoBehaviour
{
    private Vector3 movePos;


    public List<SendToRecycler> recycleList;
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
        int i = UnityEngine.Random.Range(0, recycleList.Count - 1);

        movePos.x = statics.nextPosition;
        recycleList[i].transform.position = movePos;
        recycleList.RemoveAt(i);
        statics.nextPosition += statics.distance;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
