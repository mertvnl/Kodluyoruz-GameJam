using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : Singleton<EffectManager>
{
    [ShowInInspector]
    public Dictionary<string, GameObject> Particles = new Dictionary<string, GameObject>();
    public GameObject ScoreFXPrefab;
    public GameObject MissFXPrefab;
    public GameObject PowerUpFXPrefab;
    public GameObject HealUpFXPrefab;
    public Transform lastBoxPos;

    private void Start()
    {
        Particles.Add("Score", ScoreFXPrefab);
        Particles.Add("Miss", MissFXPrefab);
        Particles.Add("PowerUp", PowerUpFXPrefab);
        Particles.Add("HealUp", HealUpFXPrefab);
    }

    private void OnEnable()
    {
        EventManager.OnScore.AddListener(PlayScoreFX);
        EventManager.OnMiss.AddListener(PlayMissFX);
        EventManager.OnDoublePowerUp.AddListener(PowerUpFX);
        EventManager.OnHealUp.AddListener(PlayHealUpFX);
    }

    private void OnDisable()
    {
        EventManager.OnScore.RemoveListener(PlayScoreFX);
        EventManager.OnMiss.RemoveListener(PlayMissFX);
        EventManager.OnDoublePowerUp.RemoveListener(PowerUpFX);
        EventManager.OnHealUp.RemoveListener(PlayHealUpFX);
    }

    private void PowerUpFX()
    {
        Instantiate(EffectManager.Instance.Particles["PowerUp"], Player.Instance.transform.position, Quaternion.identity);
    }

    private void PlayMissFX()
    {
        Instantiate(EffectManager.Instance.Particles["Miss"], lastBoxPos.position, Quaternion.identity);
    }

    private void PlayScoreFX()
    {
        Instantiate(EffectManager.Instance.Particles["Score"], lastBoxPos.position, Quaternion.identity);
    }

    private void PlayHealUpFX()
    {
        Instantiate(EffectManager.Instance.Particles["HealUp"], Player.Instance.transform.position, Quaternion.identity);
    }
}
