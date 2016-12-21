using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{

    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "I Open";
        strings[1] = "I Close";
        strings[2] = "I Reset";

        foreach (string item in strings)
        {
            print(item);
        }
    }
}