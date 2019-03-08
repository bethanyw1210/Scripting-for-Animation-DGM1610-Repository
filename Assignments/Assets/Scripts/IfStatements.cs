using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

    public string stopLight;
    public bool isUtahn = true;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(stopLight == "Red")
        {
            //Block of code that is run if the condition is met

            if(isUtahn)
            {
                print("STOP! The light is RED!");
            }
            else
            {
                print("Thank you for stopping at the red light.");
            }
        }
        else if(stopLight == "Yellow")
        {
            if(isUtahn)
            {
                print("Speed up, see if you can make it!");
            }
            else
            {
                print("Thank you for preparing to stop.");
            }
        }

        else if(stopLight == "Green")
        {

            if(isUtahn)
            {

                print("Check phone, turn up radion, sit at light until almost yellow, then go!");
            }
            else
            {
                print("Thank you for accelerating forward when the light is green.");
            }
        }

        else
        {
            print("Sorry, you are driving in Utah.");
        }
    }
}
