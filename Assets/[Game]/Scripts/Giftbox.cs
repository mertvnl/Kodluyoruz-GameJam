using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giftbox : MonoBehaviour
{
    public float downSpeed;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }
    void Start()
    {
        Destroy(gameObject, 5f);
        float gravityY = Physics.gravity.y;
        Rigidbody.velocity = new Vector3(0, gravityY, -GameManager.Instance.gameSpeed);
    }
}
