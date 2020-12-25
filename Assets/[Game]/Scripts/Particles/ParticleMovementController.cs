using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ParticleMovementController : MonoBehaviour
{
    private void Start()
    {
        transform.position += Vector3.down / 2;
    }
    private void Update()
    {

        transform.position = new Vector3(Player.Instance.transform.position.x, transform.position.y, Player.Instance.transform.position.z);
    }
}
