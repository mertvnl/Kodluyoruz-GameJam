using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : CollectableBase
{
    private void Update()
    {
        DestroyIfNotCollected();
        if (GameManager.Instance.isGameStarted)
            MovePowerUp();
    }

    private void MovePowerUp()
    {
        transform.position += Vector3.back * GameManager.Instance.gameSpeed * Time.deltaTime;
    }

    public override void Collect()
    {
        base.Collect();
    }
    public override void Use()
    {
        GameManager.Instance.HealUp();
        EventManager.OnHealUp.Invoke();
    }

    private void DestroyIfNotCollected()
    {
        if (transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
    }
}
