using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    //private Rigidbody rb;
    //public Rigidbody Rb { get { return (rb == null) ? rb = GetComponent<Rigidbody>() : rb; } }
    private void Update()
    {
        transform.position += Vector3.back * GameManager.Instance.gameSpeed * Time.deltaTime;
    }
}
