using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

    public GameObject sound;
    private void Start()
    {
        sound.SetActive(false);
    }
    //Runs when the player moves into this trigger
    void OnTriggerEnter(Collider other)
    {
        //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            sound.SetActive(true);
        }
    }
}
