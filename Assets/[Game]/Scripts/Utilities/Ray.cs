using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : Singleton<Ray>
{
    public Vector3 rayRotation;
    public float maxDistance=1000f;
    public GameObject TargetPrefab;
    public Transform Target;
    public Vector3 aimPoint;

    private void Start()
    {
        InitializeTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isGameStarted)
        {
            FollowTarget();
        } 
    }

    private void FollowTarget()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, maxDistance))
        {
            Target.transform.position = new Vector3(hit.point.x, hit.point.y, transform.position.z);
        }
    }

    public void InitializeTarget()
    {
        Instantiate(TargetPrefab);
        Target = GameObject.FindWithTag("Target").transform;
    }
}
