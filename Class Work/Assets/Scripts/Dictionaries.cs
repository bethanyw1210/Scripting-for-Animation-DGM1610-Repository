using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

    public Hashtable personalDetails = new Hashtable;

	// Use this for initialization
	void Start () {

        personalDetails.Add("firstName","Greg");
        personalDetails.Add("lasName","Lubosek");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried",true);
        personalDetails.Add("Age",29);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
