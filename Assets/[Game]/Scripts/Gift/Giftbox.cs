using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Giftbox : MonoBehaviour
{
    
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }
    void Start()
    {
        transform.Rotate(new Vector3(-90, 0, 0));
        float gravityY = Physics.gravity.y;
        Rigidbody.velocity = new Vector3(0, gravityY, -GameManager.Instance.gameSpeed);
    }


    //private void OnEnable()
    //{
    //    EventManager.OnScore.AddListener(PlayScoreFX);
    //    EventManager.OnMiss.AddListener(PlayMissFX);
    //    EventManager.OnDoublePowerUp.AddListener(PowerUpFX);
    //    EventManager.OnHealUp.AddListener(PowerUpFX);
    //}

    //private void OnDisable()
    //{
    //    EventManager.OnScore.RemoveListener(PlayScoreFX);
    //    EventManager.OnMiss.RemoveListener(PlayMissFX);
    //    EventManager.OnDoublePowerUp.RemoveListener(PowerUpFX);
    //    EventManager.OnHealUp.RemoveListener(PowerUpFX);
    //}

    //private void PowerUpFX()
    //{
    //    StartCoroutine(PowerUpFXCo());
    //}

    //IEnumerator PowerUpFXCo()
    //{
    //    Instantiate(EffectManager.Instance.Particles["PowerUp"], Player.Instance.transform.position, Quaternion.identity);
    //    yield return new WaitForSeconds(10f);
    //    Destroy(EffectManager.Instance.Particles["PowerUp"]);
    //}

    //private void PlayMissFX()
    //{
    //    Instantiate(EffectManager.Instance.Particles["Miss"], transform.position, Quaternion.identity);
    //}

    //private void PlayScoreFX()
    //{
    //    Instantiate(EffectManager.Instance.Particles["Score"],transform.position,Quaternion.identity);

    //}

    private void OnTriggerEnter(Collider other)
    {
        Chimney chimney = other.GetComponent<Chimney>();
        if (chimney != null)
        {
            EffectManager.Instance.lastBoxPos = transform;
            ScoreManager.Instance.ScoreUp();
            EventManager.OnScore.Invoke();
            Destroy(gameObject);
        }
        else
        {
            EffectManager.Instance.lastBoxPos = transform;
            GameManager.Instance.LoseHealth();
            ScoreManager.Instance.ScoreDown();
            EventManager.OnMiss.Invoke();
            Destroy(gameObject);
        }
    }
}
