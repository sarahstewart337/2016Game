using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    public Button startText;
    public Button quitText;
    public Button restartText;

    void Start()
    {
        
        startText = startText.GetComponent<Button> ();
        quitText = quitText.GetComponent<Button> ();
        restartText = restartText.GetComponent<Button> ();
    }


    public void RestartLevel()
    {
        
        SceneManager.LoadScene(1);
    }

    public void QuitLevel()
    {
        //SceneManager.LoadScene (0);
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene (0);
    }

    

    

}


