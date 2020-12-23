using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : Singleton<GameManager>
{
    public float gameSpeed = 5f;
    public float gameSpeedMultiplier = 0.05f;
    private float lastGameSpeed;
    public int playerHealth = 3;
    public bool isGameStarted;
    public bool isGameOver;

    private void OnEnable()
    {
        EventManager.OnScore.AddListener(SpeedUp);
        EventManager.OnGameOver.AddListener(Die);
        EventManager.OnGameStart.AddListener(() => isGameStarted = true);
    }

    private void OnDisable()
    {
        EventManager.OnScore.RemoveListener(SpeedUp);
        EventManager.OnGameOver.RemoveListener(Die);
        EventManager.OnGameStart.RemoveListener(() => isGameStarted = false);
    }

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

    public void LoseHealth()
    {
        if (playerHealth > 0)
        {
            playerHealth--;
        }
        if (playerHealth <= 0)
        {
            EventManager.OnGameOver.Invoke();
        }
        
    }

    public void HealUp()
    {
        if (playerHealth < 3)
        {
            playerHealth++;
            Debug.Log("Heal up");
        }
    }

    public void Die()
    {
        Time.timeScale = 0;
        isGameStarted = false;
    }
}
