﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather;

    // Called variable function
    void Start() {
        print(Sum(36,24));

        print(Multi(20,5));
    }
    /*Weather(weather);
}

void Weather(string weatherState){

    if(weatherState == "Sunny"){
        print("The sun is shining today");
    }
    else if(weatherState == "Raining"){
        print("It is soggy and wet today");
    }
    else if(weatherState == "Windy"){
        print("It is very windy today");
    }
    else if(weatherState == "Snowing"){
        print("It is a blizzard out there!");
    }
    else if(weatherState == "Foggy"){
        print("Visability is very poor due to fog.");
    }
    else{
        print("I don't get what you're trying to say, idiot."+ weatherState);
    }

}*/

    int Sum(int a,int b)
        {
            return a + b;
        }
    int Multi(int c, int d)
    {
        return c * d;
    }
}	
