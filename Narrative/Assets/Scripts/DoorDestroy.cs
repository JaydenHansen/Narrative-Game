using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroy : MonoBehaviour
{


    public GameObject door;
    public GameObject door1;
    public GameObject sound;

    private void Start()
    {
        door.SetActive(false);
        sound.SetActive(false);
    }
    //Runs when the player moves into this trigger
    void OnTriggerEnter(Collider other)
    {
        //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            door.SetActive(true);
            door1.SetActive(false);
            sound.SetActive(true);
        }
    }
}
   