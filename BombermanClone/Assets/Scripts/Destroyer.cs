﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    public float time = 3;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
}
