﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text scoreTxt;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void IncreaseScore(int point)
    {
            score += point;
            scoreTxt.text = score.ToString();
    }
}
