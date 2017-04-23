﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.isStatic)
            Destroy(collision.gameObject);
    }
}
