using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public Transform spawnObject;
    public int spawnTotal;
    public float timeBetweenSpawn;
    public bool canSpawnKeys = true;
    private int i = 0;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(SpawnGameObject());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator SpawnGameObject()
    {
        for (var x = 0; x <spawnTotal; x++)
        {
            while(canSpawnKeys)
            {
                
            }
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}
