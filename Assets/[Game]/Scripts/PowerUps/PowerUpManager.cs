using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public List<GameObject> powerUpPrefabs;
    public List<Transform> powerUpSpawnLanes;
    private float spawnDelay = 30f;
    private float spawnTime = 20f;
    public float minSpawnRatio = 20f, maxSpawnRatio = 30f;

    private void OnEnable()
    {
        EventManager.OnGameStart.AddListener(CreatePowerUp);
    }
    private void OnDisable()
    {
        EventManager.OnGameStart.RemoveListener(CreatePowerUp);
    }

    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            //CreatePowerUp();
        }
    }
    private Vector3 GetRandomLane()
    {
        return powerUpSpawnLanes[Random.Range(0, powerUpSpawnLanes.Count)].position;
    }

    private GameObject GetRandomPowerUp()
    {
        return powerUpPrefabs[Random.Range(0, powerUpPrefabs.Count)];
    }

    private void CreatePowerUp()
    {
        //if (Time.timeSinceLevelLoad > spawnTime)
        //{
        //    spawnTime += spawnDelay;
        //    Instantiate(GetRandomPowerUp(), GetRandomLane(), Quaternion.identity);
        //    Debug.Log("power up created");
        //}
        StartCoroutine(CreatePowerUpCo());
    }

    private IEnumerator CreatePowerUpCo()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnRatio,maxSpawnRatio));
            Debug.Log("power up created");
            Instantiate(GetRandomPowerUp(), GetRandomLane(), Quaternion.identity);
        }
    }
}
