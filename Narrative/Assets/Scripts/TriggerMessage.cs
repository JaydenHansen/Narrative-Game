using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour {

    public string messageToShow = "Default Message";
    public float messageDuration = 3;


    //Runs when the player moves into this trigger
    void OnTriggerEnter(Collider other)
    {
           //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
                ShowMessage(messageToShow, messageDuration);
        }
    }

}

