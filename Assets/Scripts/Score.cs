﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    void Awake ()
    {
        scoreText = GetComponent<Text>();
    }

}
