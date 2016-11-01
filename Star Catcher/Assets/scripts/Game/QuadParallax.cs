using UnityEngine;
using System.Collections;

public class QuadParallax : MonoBehaviour
{
    public float speed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 offset = new Vector2(speed * Time.time, 0);

        // Vector3 offset = new Vector3(Time.deltaTime * speed,0);

        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
