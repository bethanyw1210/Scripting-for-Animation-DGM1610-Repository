using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

    public float speed;

    public float timeOut;
    public GameObject player;

    public GameObject enemyDeath;

    public GameObject projectileParticle;

    public int pointsForKill;

	// Use this for initialization
	void Start () {

        player = GameObject.Find("Player");

        enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

        projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

        if(player.transform.localScale.x < 0)
            speed = -speed;

        //Destroys Projectiles after X seconds
        Destroy(gameObject,timeOut);
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
		
	}

    private void OnTriggerEnter(Collider2D other)
    {
       if(other.tag == "Enemy")
        {
            Instantiate(enemyDeath,other.transform.position,other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
        }

        Destroy(gameObject); 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(projectileParticle,transform.position,transform.rotation);
        Destroy(gameObject);
    }

}
