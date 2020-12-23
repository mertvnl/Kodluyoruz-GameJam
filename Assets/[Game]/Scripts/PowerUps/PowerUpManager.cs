using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public List<GameObject> powerUpPrefabs;
    public List<Transform> powerUpSpawnLanes;
    public float spawnDelay = 30f;
    private float spawnTime = 20f;

    private void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            CreatePowerUp();
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
        if (Time.time > spawnTime)
        {
            spawnTime += spawnDelay;
            Instantiate(GetRandomPowerUp(), GetRandomLane(), Quaternion.identity);
        }
        
    }

    private IEnumerator CreatePowerUpCo()
    {
        while (GameManager.Instance.isGameStarted)
        {
            yield return new WaitForSeconds(20f);
            Debug.Log("power up created");
            Instantiate(GetRandomPowerUp(), GetRandomLane(), Quaternion.identity);
        }
    }
}
