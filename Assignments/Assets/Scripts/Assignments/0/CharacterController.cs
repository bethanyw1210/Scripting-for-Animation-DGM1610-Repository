using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed=1;
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //creating a conditional, when we want to make a decision
        if(Input.GetKey(KeyCode.D)){
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,player.GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.A)){
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,player.GetComponent<Rigidbody2D>().velocity.y);
        }
	}

}
