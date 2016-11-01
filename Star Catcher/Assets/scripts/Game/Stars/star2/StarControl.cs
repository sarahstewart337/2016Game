﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class StarControl : MonoBehaviour
{
    public List<StarSpawner> spawners;
    public List<star> stars;

    void SpawnerHandler (Transform _t)
    {
        spawners.Add( _t);
    }

    void starHandler (Transform _t)
    {
        stars.Add(_t);
    }
	// Use this for initialization
	void Start ()
    {
        StarSpawner.SendSpawner += SpawnerHandler;
        star.SendStar += starHandler;
        if (stars != null && spawners != null)
        {
            StartCoroutine(Spawn());
        }
	}

    private bool canSpawn = true;
    private int starNum;
    private int spawnerNum;
	IEnumerator Spawn()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(1);
            stars[starNum].position = spawners[spawnerNum].position;
            stars[starNum].GetComponent<MeshRenderer>().enabled = true;
            if (starNum < stars.Count-1)
            {
                starNum ++ ;
                
            }
            else
            {
                starNum = 0;
            }
            if (spawnerNum < spawners.Count - 1)
            {
                spawnerNum++;

            }
            else
            {
                spawnerNum = 0;
            }
        }
        
    }
}
