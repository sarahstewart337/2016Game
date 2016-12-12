using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform star;
    private int i = 0;
    public float spawnFrequency = 1;
    public bool canSpawnStars = true;
	
    IEnumerator SpawnStars()
    {
        while (canSpawnStars)
        {
            i = Random.Range(0, spawnPoints.Length-1);
            print(spawnPoints.Length);
           Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
            
        }
        
    }
    // Use this for initialization
	void Start ()
    {
        StartCoroutine(SpawnStars());
	
	}
	
	
}
