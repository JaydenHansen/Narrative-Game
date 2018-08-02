using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour {

    public GameObject text;

    private void Start()
    {
        text.SetActive(false);
    }
    //Runs when the player moves into this trigger
    void OnTriggerStay(Collider other)
    {
           //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            text.SetActive (true) ; 
        }
        else
        {
            text.SetActive(false);
        }
    }


}

