using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundery1 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        NextLevel ();
    }

    public void NextLevel ()
    {


        SceneManager.LoadScene(3);
      
    }
	// Use this for initialization
	void Start ()
    {
     

    }
	
	// Update is called once per frame
	void Update ()
    {
      
    }
}
