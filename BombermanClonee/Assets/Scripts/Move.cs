using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 6;
    void FixedUpdate() {
        float dikey = Input.GetAxisRaw("Horizontal");
        float yatay = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(dikey, yatay) * speed;

        GetComponent<Animator>().SetInteger("X", (int)dikey);
        GetComponent<Animator>().SetInteger("Y", (int)yatay);
    }
}
