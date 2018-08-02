using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage : MonoBehaviour {

    public Text text;

    private void Start()
    {
        text.canvasRenderer.SetAlpha(0.0f);
        Invoke("FadeInText", 2);
    }
    //Runs when the player moves into this trigger
    void OnTriggerEnter(Collider other)
    {
           //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            text.CrossFadeAlpha(1.0f, 3, true);
        }      
    }
    void OnTriggerExit(Collider other)
    {
        //Checks if the tag of the object that enters is "Player"
        if (other.tag == "Player")
        {
            text.CrossFadeAlpha(0, 1, false);
        }
    }


}

