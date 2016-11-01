using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundery : MonoBehaviour
{
    void OnTriggerEnter()
    {
        RestartLevel ();
    }

    public void RestartLevel ()
    {


        SceneManager.LoadScene(0);
      
    }
	// Use this for initialization
	void Start ()
    {
        statics.nextPosition = statics.startPosition;

    }
	
	// Update is called once per frame
	void Update ()
    {
      
    }
}
