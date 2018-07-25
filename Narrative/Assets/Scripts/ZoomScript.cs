using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomScript : MonoBehaviour {

    public Camera myCamera;
    public float maxZoom;
    public float zoomSpeed;

    float defultZoom;
    float targetZoom;

	// Use this for initialization
	void Start () {

        defultZoom = myCamera.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1))
        {
            targetZoom = maxZoom;
        }
        else
        {
            targetZoom = defultZoom;
        }

        myCamera.fieldOfView = Mathf.Lerp(myCamera.fieldOfView, targetZoom, Time.deltaTime * zoomSpeed);
	}
}
