using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach1 : MonoBehaviour
{

    void Start()
    {
        string[] strings = new string[2];

        strings[0] = "Move Character";
        strings[1] = "Go Through Door";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}