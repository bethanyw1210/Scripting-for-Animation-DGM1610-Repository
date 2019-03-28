using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed=1;
    public int jumpHeight = 10;

    //player grounded variable 
    private bool grounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public GameObject player;

	// Use this for initialization
	void Start () {
        // default to true when grounded 
        grounded = true;
		
	}
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
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
        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump();
        }
	}
    // Skyler showing me how to make player jump once with no double jumps
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            grounded = true;
        }
    }

    // make player jump
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
    }

}
