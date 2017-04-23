using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public GameObject explodedOne;

    void OnDestroy()
    {
        Instantiate(explodedOne, transform.position, Quaternion.identity);
    }
}