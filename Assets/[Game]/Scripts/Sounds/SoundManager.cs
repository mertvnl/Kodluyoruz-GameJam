  
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : Singleton<SoundManager>
{
    private AudioSource playerAudioSource;
    public AudioSource PlayerAudioSource
    {
        get
        {
            if(playerAudioSource==null)
            {
                playerAudioSource=GetComponent<AudioSource>();
            }
            return playerAudioSource;
        }
    }
    public AudioClip ScoreUpSound;
    public AudioClip LooseHealthSound;
    public AudioClip ThemeSound;
    public AudioClip PowerUpSound;
    public AudioClip GameOverSound;

    private void OnEnable()
    {
        EventManager.OnScore.AddListener(ScoreUpSoundFX);
        EventManager.OnMiss.AddListener(LooseHealthSoundFX);
        EventManager.OnGameOver.AddListener(GameOverSoundFX);
        EventManager.OnGameStart.AddListener(GameStartSoundFX);
        EventManager.OnHealUp.AddListener(PowerUpSoundFX);
        EventManager.OnDoublePowerUp.AddListener(PowerUpSoundFX);
    }

    private void OnDisable()
    {
        EventManager.OnScore.RemoveListener(ScoreUpSoundFX);
        EventManager.OnMiss.RemoveListener(LooseHealthSoundFX);
        EventManager.OnGameOver.RemoveListener(GameOverSoundFX);
        EventManager.OnGameStart.RemoveListener(GameStartSoundFX);
        EventManager.OnHealUp.RemoveListener(PowerUpSoundFX);
        EventManager.OnDoublePowerUp.RemoveListener(PowerUpSoundFX);
    }



    private void ScoreUpSoundFX()
    {
        PlayerAudioSource.PlayOneShot(ScoreUpSound, 0.5f);
        Debug.Log("ScoreUp");

    }

    private void PowerUpSoundFX()
    {
        PlayerAudioSource.PlayOneShot(PowerUpSound, 0.5f);
        Debug.Log("Power Up");
    }

    private void LooseHealthSoundFX()
    {
        PlayerAudioSource.PlayOneShot(LooseHealthSound, 0.5f);
        Debug.Log("LooseHealth");
    }

    private void GameOverSoundFX()
    {
        PlayerAudioSource.PlayOneShot(LooseHealthSound, 0.5f);
        PlayerAudioSource.Stop();
        Debug.Log("GameOver");
    }

    private void GameStartSoundFX()
    {
        //SoundManager.Instance.PlayerAudioSource.Play();
        Debug.Log("GameStart");
    }



}
  