﻿using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {
    private Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(-speed, rb.velocity.y);

    }
}
