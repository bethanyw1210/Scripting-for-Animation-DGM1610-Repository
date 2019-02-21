using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed=1;
    public int jumpHeight = 10;

    //player grounded variable 
    private bool grounded; 
    public GameObject player;

	// Use this for initialization
	void Start () {
        // defualt to true when grounded 
        grounded = true;
		
	}
        // && = this AND that
        // || = this OR that
        // !Not this 
	
	// Update is called once per frame
	void Update () {
        //moves player left and right
        //creating a conditional, when we want to make a decision
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,player.GetComponent<Rigidbody2D>().velocity.y);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,player.GetComponent<Rigidbody2D>().velocity.y);
        }

        //makes player jump
        else if(Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight); 
        }
	}

}
