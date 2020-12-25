using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePointsPowerUp : CollectableBase
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
        EventManager.OnDoublePowerUp.Invoke();

    }
public override void Use()
    {
        ScoreManager.Instance.DoubleScore();
    }

    private void DestroyIfNotCollected()
    {
        if (transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
    }

}
