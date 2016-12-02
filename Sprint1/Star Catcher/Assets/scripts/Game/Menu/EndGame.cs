using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Button menuText;

    // Use this for initialization
    void Start()
    {
        menuText = menuText.GetComponent<Button>();

    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }
}


