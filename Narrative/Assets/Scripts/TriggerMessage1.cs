using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerDisplay))]
public class TriggerMessage1 : MonoBehaviour {

    public string messageToShow = "Default Message";
    public float messageDuration = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindObjectsOfType<UIController>().ShowMessage(messageToShow, messageDuration);
        }
    }
}
