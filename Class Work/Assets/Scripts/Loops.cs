using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    public int bottles = 100;
    public bool isRaining = true;

	// Use this for initialization
	void Start () {
        //do while loop
        bool shouldContinue = false;

        /*for loops
         i++ means add one*/
        /*loops goping forward*/
         for(int i=1; i <= bottles; i++){
            print(bottles + " bottles of toes on the wall");
        }
        /*loops going backward
        * for(int i = 1;i > bottles;i--)
        {
            print(bottles + " bottles of toes on the wall");
        }

        do
        {
            print("Hello World");
        } while(shouldContinue == true);*/

        //ForEach Loop
        /*string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second String";
        strings[2] = "Third string";

        foreach(string item in strings)
        {
            print(item);
        }

        /*while(bottles <= 100)
        {
            print(bottles + " of beer on the wall.");
            bottles ++;
        }*/

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
