﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
	
	void LateUpdate () {
        transform.position = new Vector3(target.position.x, target.position.y + 5f, -15f);
	}
}
