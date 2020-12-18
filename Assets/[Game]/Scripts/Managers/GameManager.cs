using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : Singleton<GameManager>
{
    public float gameSpeed = 5f;
    public float gameSpeedMultiplier = 0.05f;
    private float lastGameSpeed;


    [Button]
    private void SpeedUp()
    {
        gameSpeed += gameSpeedMultiplier;
    }

    [Button]
    private void StopTheGame()
    {
        lastGameSpeed = gameSpeed;
        gameSpeed = 0;
    }
    [Button]
    private void ContinueTheGame()
    {
        gameSpeed = lastGameSpeed;
    }
}
