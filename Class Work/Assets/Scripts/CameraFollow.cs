using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        isFollowing = true;
		
	}
	
	// Update is called once per frame
	void Update () {
        if(isFollowing)
        {
            transform.position = new Vector3(player.transform.positions.x + xOffset, player.t)
        }
		
	}
}
