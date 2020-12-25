using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    //private void OnEnable()
    //{
    //    EventManager.OnDoublePowerUp.AddListener(PowerUpFX);
    //    EventManager.OnHealUp.AddListener(PowerUpFX);
    //}

    //private void OnDisable()
    //{
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
}
