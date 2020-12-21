using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int score = 0;
    public void ScoreDown()
    {
        if (score > 0)
        {
            score--;
        }
        
    }

    public void ScoreUp()
    {
        score++;
    }
}
