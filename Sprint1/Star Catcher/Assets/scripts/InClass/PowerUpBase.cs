﻿using UnityEngine;
using System.Collections;
using System;

public class PowerUpBase : MonoBehaviour
{

    public string firstName;
    public string lastName;
    private string userName;

    void OnMouseUp()
    {
        print(UserInfo());
        print(userName + " is your User Name.");
    }

    string UserInfo()
    {
        userName = firstName + lastName + 1138;
        return firstName + " " + lastName + "are you ready to play?";

    }

}
