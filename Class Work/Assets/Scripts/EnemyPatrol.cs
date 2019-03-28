﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {
    //movement variables
    public float moveSpeed;
    public bool moveRight;

    //wall check
    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    //edge check
    private bool notAtEdge;
    public Transform edgeCheck;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position,wallCheckRadius,whatIsWall);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position,wallCheckRadius,whatIsWall);

        if (hittingWall || !notAtEdge)
        {
            moveRight = !moveRight;
        }
        if(moveRight)
        {
            transform.localScale = new Vector3(-2f,2f,1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
        }

        else
        {
            transform.localScale = new Vector3(-2f,2f,1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        HealthBar.health -= 10f;
    }

}
