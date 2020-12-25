using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleZMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.back * GameManager.Instance.gameSpeed * Time.deltaTime; ;
    }
}
