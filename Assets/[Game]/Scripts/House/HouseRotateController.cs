﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseRotateController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = new Quaternion(transform.rotation.x, 90, transform.rotation.z, transform.rotation.w);
    }

}
