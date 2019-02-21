using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int coinValue;


    //tell coin what to do when player intersects it 
    // use an argument, its in parenthesis 
	void OnTriggerEnter2D (Collider2D other)
    {
        if(other.name == "Player")
            print("You've collected a coin!");

        Destroy(gameObject);
    }
}
