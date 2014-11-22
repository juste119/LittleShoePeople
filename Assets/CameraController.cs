﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject shoePlayer;
    Vector3 cameraOffset = new Vector3(7, 0, -10);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(shoePlayer.transform.position.x + cameraOffset.x, gameObject.transform.position.y, shoePlayer.transform.position.z + cameraOffset.z);
	
	}
}
