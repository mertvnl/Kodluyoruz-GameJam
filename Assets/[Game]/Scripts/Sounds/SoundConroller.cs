//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SoundConroller : MonoBehaviour
//{
//    // Start is called before the first frame update
//    private void OnEnable() 
//    {
//        EventManager.OnScore.AddListener(ScoreUpSound);
//        EventManager.OnMiss.AddListener(LooseHealthSound);
//        EventManager.OnGameOver.AddListener(GameOverSound);
//        EventManager.OnGameStart.AddListener(GameStartSound);
//        EventManager.OnHealUp.AddListener(PowerUpSound);
//        EventManager.OnDoublePowerUp.AddListener(PowerUpSound);
//    }

//    private void OnDisable() 
//    {
//        EventManager.OnScore.RemoveListener(ScoreUpSound);
//        EventManager.OnMiss.RemoveListener(LooseHealthSound);
//        EventManager.OnGameOver.RemoveListener(GameOverSound);
//        EventManager.OnGameStart.RemoveListener(GameStartSound);
//        EventManager.OnHealUp.RemoveListener(PowerUpSound);
//        EventManager.OnDoublePowerUp.RemoveListener(PowerUpSound);
//    }



//    private void ScoreUpSound ()
//    {
//        SoundManager.Instance.PlayerAudioSource.PlayOneShot(SoundManager.Instance.ScoreUpSound,0.5f);
//        Debug.Log("ScoreUp");

//    }

//    private void PowerUpSound()
//    {
//        SoundManager.Instance.PlayerAudioSource.PlayOneShot(SoundManager.Instance.PowerUpSound,0.5f);
//        Debug.Log("Power Up");
//    } 

//    private void LooseHealthSound()
//    {
//        SoundManager.Instance.PlayerAudioSource.PlayOneShot(SoundManager.Instance.LooseHealthSound,0.5f);
//        Debug.Log("LooseHealth");
//    }

//    private void GameOverSound()
//    {
//        SoundManager.Instance.PlayerAudioSource.PlayOneShot(SoundManager.Instance.LooseHealthSound,0.5f);
//        SoundManager.Instance.PlayerAudioSource.Stop();
//        Debug.Log("GameOver");
//    }

//    private void GameStartSound()
//    {
//        //SoundManager.Instance.PlayerAudioSource.Play();
//        Debug.Log("GameStart");
//    }

    
//}
