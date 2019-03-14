using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches:MonoBehaviour
{
    public string suspect;

    public string weapon;

    public string room;

    // Use this for initialization
    void Start()
    {
        MurderMystery(suspect);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void MurderMystery(string person)
    {
        switch(person)
        {
            case "Mr. Ketchup":
                print("I was in the billiard room smoking dope with Mr. Radish.");
                break;
            case "Mr. Radish":
                print("I was in the billiard room with Mr. Ketchup.");
                break;
            case "Ms. Frysauce":
                print("I was talking on the rotory phone with my mother, Ms. Mayo.");
                break;
            case "Mrs. Mayo":
                print("I was in the kitchen cleaning up the dishes.");
                break;
            default:
                print("I am not familiar with" + suspect + "!");
                MurderMystery(suspect);
                break;
        }
    }
}
       


