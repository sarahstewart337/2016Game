using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timeLeft = 100.0f;
    public float myTimer = 99;
    public Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        myTimer -= Time.deltaTime;
        timerText.text = myTimer.ToString("f2");

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(0);
        }



    }
}

