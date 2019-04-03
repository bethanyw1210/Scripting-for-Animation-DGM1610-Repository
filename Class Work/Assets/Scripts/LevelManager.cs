using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    //update cycle
        //fixed update: physics and initialize
        //update: general code
        //late update: 

    //coroutine:
        //autosave
        //timer
        //respawn player

    public class GameObject currentCheckPoint;
    private Rigidbody2D pcRigid;

    private GameObject player;

    // Particles
    public GameObject deathParticle;
    public GameObject respawnParticle;

    //Respawn Delay
    public float respawnDelay;

    //Point penalty on death
    public int pointPenaltyOnDeath;

    //Store gravity value
    private float gravityStore;


	// Use this for initialization
	void Start () {
        pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        //Generate Death Particle
        Instantiate(deathParticle,pcRigid.transform.position,pcRigid.transform.rotation);
        player.SetActive(false);
        pcRigid.GetComponent<Renderer>().enabled = false;
        //Gravity Reset
        gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point Penalty
        ScoreManager.AddPoints(-PointPenaltyOnDeath);
        //Debug Message
        Debug.Log("PC Respawn");
        //Respawn Delay
        yield return new WaitForSeconds(respawnDelay);
        //Gravity Restore
        pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //Match PCs transform position
        pcRigid.transform.position = CurrentCheckPoint.transform.position;
        //Show Pc
        player.SetActive(true);
        pcRigid.GetComponent<Renderer>().enabled = true;
        //Spawn Pc
        Instantiate(respawnParticle,currentCheckPoint.transform.position,currentCheckPoint.tr);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
