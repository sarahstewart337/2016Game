﻿using UnityEngine;
using System.Collections;

public class MoveRecycleTrigger : MonoBehaviour {

    private Vector3 movePos;
    public float speed = 1;
	
	// Update is called once per frame
	void Update ()
    {
        movePos.x = speed;
        transform.Translate(movePos);
	
	}
}
