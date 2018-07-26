using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipToe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey("space"))
        {
            transform.position = transform.position + new Vector3(0, 0.05f, 0);
        }
      //  else
       // {
       //     transform.position = transform.position + new Vector3(0, 0, 0);
      //  }
	}
}
