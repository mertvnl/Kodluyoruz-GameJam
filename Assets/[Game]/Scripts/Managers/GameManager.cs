using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : Singleton<GameManager>
{
    public float gameSpeed = 5f;
    public float gameSpeedMultiplier = 0.05f;


    [Button]
    private void SpeedUp()
    {
        gameSpeed += gameSpeedMultiplier;
    }
}
